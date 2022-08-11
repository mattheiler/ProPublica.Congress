using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json.Linq;

namespace ProPublica.Congress.Http
{
    public class ProPublicaCongressApiClient : IDisposable
    {
        private readonly IFlurlClient _http;

        private readonly SemaphoreSlim _requests = new SemaphoreSlim(2, 2);

        private bool _disposed;

        public ProPublicaCongressApiClient(IFlurlClient http)
        {
            _http = http;
        }

        public ProPublicaCongressApiClient(IFlurlClientFactory http, string key)
            : this(http.Get("https://api.propublica.org/congress/v1/").WithHeader("X-API-KEY", key))
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ProPublicaCongressApiClient()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;
            if (disposing)
                _requests.Dispose();
            _disposed = true;
        }

        public Task<ClientResponse> GetAsync(string requestUri, Action<ClientRequestBuilder> requestBuilderSetup = null)
        {
            var requestBuilder = new ClientRequestBuilder(requestUri);

            requestBuilderSetup?.Invoke(requestBuilder);

            var request = requestBuilder.GetRequest();

            return GetAsync(request);
        }

        private async Task<ClientResponse> GetAsync(ClientRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                await _requests.WaitAsync(cancellationToken);

                while (true)
                {
                    var flurl = _http.Request(request.Path).SetQueryParams(request.Query).AllowAnyHttpStatus();

                    using var response = await flurl.GetAsync(cancellationToken);

                    switch ((HttpStatusCode) response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            break;
                        case HttpStatusCode.BadRequest:
                        case HttpStatusCode.Forbidden:
                        case HttpStatusCode.NotFound:
                        case HttpStatusCode.NotAcceptable:
                            throw new InvalidOperationException(response.StatusCode.ToString());
                        case HttpStatusCode.TooManyRequests:
                            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                            continue;
                        case HttpStatusCode.InternalServerError:
                        case HttpStatusCode.GatewayTimeout:
                            await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
                            continue;
                        //throw new InvalidOperationException($"Gateway timeout! ({response.RequestMessage.RequestUri})");
                        case HttpStatusCode.ServiceUnavailable:
                            throw new InvalidOperationException("Service is unavailable.");
                        default:
                            throw new InvalidOperationException($"Something unexpected happened. ({response.StatusCode})");
                    }

                    var content = await response.GetStringAsync();
                    var results = new ClientResponse(JObject.Parse(content));

                    var message = results.GetMessage();
                    if (message != null)
                        throw new InvalidOperationException(message);

                    var status = results.GetStatus();

                    return status switch
                    {
                        ClientResponseStatus.Ok => results,
                        ClientResponseStatus.Error => throw new InvalidOperationException(string.Join(Environment.NewLine, results.GetErrors())),
                        ClientResponseStatus.InternalServerError => throw new InvalidOperationException("Internal server error!"), _ => throw new ArgumentOutOfRangeException($"Invalid response status: {status}.")
                    };
                }
            }
            finally
            {
                _requests.Release();
            }
        }

        #region Votes

        public async Task<IEnumerable<VoteHeader>> GetVotes(string chamber, int index)
        {
            var response = await GetAsync($"{chamber}/votes/recent.json", options => options.Page(index));
            return response.Many<VoteHeader>("votes");
        }

        public async Task<Vote> GetVote(int congress, string chamber, int session, int rollcall)
        {
            var response = await GetAsync($"{congress}/{chamber}/sessions/{session}/votes/{rollcall}.json");
            return response.One<Vote>("votes.vote");
        }

        #endregion

        #region Bills

        public async Task<IEnumerable<BillHeader>> GetBills(int congress, int index)
        {
            var response = await GetAsync($"{congress}/both/bills/introduced.json", options => options.Page(index));
            return response.Many<BillHeader>("bills");
        }

        public async Task<Bill> GetBill(int congress, string slug)
        {
            var response = await GetAsync($"{congress}/bills/{slug}.json");
            return response.One<Bill>();
        }

        public async Task<IEnumerable<BillAmendment>> GetBillAmendments(int congress, string slug, int index)
        {
            var response = await GetAsync($"{congress}/bills/{slug}/amendments.json", options => options.Page(index));
            return response.Many<BillAmendment>("amendments");
        }

        public async Task<IEnumerable<BillCosponsor>> GetBillCosponsors(int congress, string slug)
        {
            var response = await GetAsync($"{congress}/bills/{slug}/cosponsors.json");
            return response.Many<BillCosponsor>("cosponsors");
        }

        public async Task<IEnumerable<BillSubject>> GetBillSubjects(int congress, string slug)
        {
            var response = await GetAsync($"{congress}/bills/{slug}/subjects.json");
            return response.Many<BillSubject>("subjects");
        }

        #endregion

        #region Committees

        public async Task<IEnumerable<CommitteeHeader>> GetCommittees(int congress, string chamber)
        {
            var response = await GetAsync($"{congress}/{chamber}/committees.json");
            return response.Many<CommitteeHeader>("committees");
        }

        public async Task<Committee> GetCommittee(int congress, string chamber, string id)
        {
            var response = await GetAsync($"{congress}/{chamber}/committees/{id}.json");
            return response.One<Committee>();
        }

        public async Task<IEnumerable<CommitteeHearing>> GetCommitteeHearings(int congress, int index)
        {
            var response = await GetAsync($"{congress}/committees/hearings.json", options => options.Page(index));
            return response.Many<CommitteeHearing>("hearings");
        }

        public async Task<IEnumerable<CommitteeHearing>> GetCommitteeHearings(int congress, string chamber, string id, int index)
        {
            var response = await GetAsync($"{congress}/{chamber}/committees/{id}/hearings.json", options => options.Page(index));
            return response.Many<CommitteeHearing>("hearings");
        }

        public async Task<Subcommittee> GetSubcommittee(int congress, string chamber, string committeeId, string subcommitteeId)
        {
            var response = await GetAsync($"{congress}/{chamber}/committees/{committeeId}/subcommittees/{subcommitteeId}.json");
            return response.One<Subcommittee>();
        }

        public async Task<IEnumerable<CommitteeStatement>> GetCommitteeStatements(int congress, string chamber, string committeeId, int index)
        {
            var response = await GetAsync($"statements/committees/{committeeId}.json", options => options.Page(index));
            var results = response.Many<CommitteeStatement>().ToList();
            
            foreach (var statement in results)
            {
                statement.ApiUri = $"https://api.propublica.org/congress/v1/{congress}/{chamber}/committees/{committeeId}.json";
                statement.CommitteeId = committeeId;
            }

            return results;
        }

        public async Task<IEnumerable<CommitteeCommunication>> GetCommitteeCommunications(int congress, int index)
        {
            var response = await GetAsync($"{congress}/communications.json", options => options.Page(index));
            return response.Many<CommitteeCommunication>();
        }

        #endregion

        #region Members

        public async Task<IEnumerable<MemberHeader>> GetMembers(int congress, string chamber)
        {
            var response = await GetAsync($"{congress}/{chamber}/members.json");
            return response.Many<MemberHeader>("members");
        }

        public async Task<IEnumerable<MemberHeader>> GetMembersEntered()
        {
            var response = await GetAsync("members/new.json");
            return response.Many<MemberHeader>("members");
        }

        public async Task<IEnumerable<MemberHeader>> GetMembersLeaving(int congress, string chamber)
        {
            var response = await GetAsync($"{congress}/{chamber}/members/leaving.json");
            return response.Many<MemberHeader>("members");
        }

        public async Task<IEnumerable<MemberHeader>> GetMembersByState(string chamber, State state)
        {
            var response = await GetAsync($"members/{chamber}/{state}/current.json");
            return response.Many<MemberHeader>();
        }

        public async Task<IEnumerable<MemberHeader>> GetMembersByStateAndDistrict(string chamber, State state, int district)
        {
            var response = await GetAsync($"members/{chamber}/{state}/{district}/current.json");
            return response.Many<MemberHeader>();
        }

        public async Task<Member> GetMember(string id)
        {
            var response = await GetAsync($"members/{id}.json");
            return response.One<Member>();
        }

        public async Task<IEnumerable<MemberVote>> GetMemberVotes(string id, int index)
        {
            var response = await GetAsync($"members/{id}/votes.json", options => options.Page(index));
            return response.Many<MemberVote>("votes");
        }

        public async Task<IEnumerable<MemberStatement>> GetMemberStatements(string id, int congress, int index)
        {
            var response = await GetAsync($"members/{id}/statements/{congress}.json", options => options.Page(index));
            return response.Many<MemberStatement>();
        }

        #endregion

        #region Expenses

        public async Task<IEnumerable<ExpensesByCategory>> GetExpensesByCategory(ExpensesByCategory category, [Range(2009, 2017)] int year, [Range(1, 4)] int quarter)
        {
            var response = await GetAsync($"office_expenses/category/{category}/{year}/{quarter}.json");
            return response.Many<ExpensesByCategory>();
        }

        public async Task<ExpensesForMemberResponse> GetExpensesForMember(string memberId, [Range(2009, 2017)] int year, [Range(1, 4)] int quarter)
        {
            var response = await GetAsync($"members/{memberId}/office_expenses/{year}/{quarter}.json");
            return response.Response<ExpensesForMemberResponse>();
        }

        public async Task<ExpensesForMemberByCategoryResponse> GetExpensesForMemberByCategory(string memberId, ExpensesByCategory category)
        {
            var response = await GetAsync($"members/{memberId}/office_expenses/category/{category}.json");
            return response.Response<ExpensesForMemberByCategoryResponse>();
        }

        #endregion

        #region Lobbying

        public async Task<IEnumerable<LobbyingRepresentation>> GetLobbyingRepresentations(int index)
        {
            var response = await GetAsync("lobbying/latest.json", options => options.Page(index));
            return response.Many<LobbyingRepresentation>("lobbying_representations");
        }

        public async Task<LobbyingRepresentationDetails> GetLobbyingRepresentation(string id)
        {
            var response = await GetAsync($"lobbying/{id}.json");
            return response.One<LobbyingRepresentationDetails>();
        }

        #endregion

        #region Statements

        public async Task<IEnumerable<Statement>> GetStatements(int index)
        {
            var response = await GetAsync("statements/latest.json", options => options.Page(index));
            return response.Many<Statement>();
        }

        public async Task<IEnumerable<StatementSubject>> GetStatementsSubjects(int index)
        {
            var response = await GetAsync("statements/subjects.json", options => options.Page(index));
            return response.Many<StatementSubject>();
        }

        #endregion

        #region Nominations

        public async Task<IEnumerable<NominationByType>> GetNominationsByType(int congress, string type, int index)
        {
            var response = await GetAsync($"{congress}/nominees/{type}.json", options => options.Page(index));
            return response.Many<NominationByType>();
        }

        public async Task<IEnumerable<NominationByState>> GetNominationsByState(int congress, string state, int index)
        {
            var response = await GetAsync($"v1/{congress}/nominees/state/{state}.json", options => options.Page(index));
            return response.Many<NominationByState>();
        }

        public async Task<NominationDetails> GetNomination(int congress, string nomineeId)
        {
            var response = await GetAsync($"{congress}/nominees/{nomineeId}.json");
            return response.One<NominationDetails>();
        }

        #endregion
    }
}