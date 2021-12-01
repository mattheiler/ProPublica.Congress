using System;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class MemberHeader
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string FirstName { get; set; }

        [JsonProperty]
        public string MiddleName { get; set; }

        [JsonProperty]
        public string LastName { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string ShortTitle { get; set; }

        [JsonProperty]
        public string ApiUrl { get; set; }

        [JsonProperty]
        public string Suffix { get; set; }

        [JsonProperty]
        public DateTime? DateOfBirth { get; set; }

        [JsonProperty]
        public string Party { get; set; }

        [JsonProperty]
        public string LeadershipRole { get; set; }

        [JsonProperty]
        public string TwitterAccount { get; set; }

        [JsonProperty]
        public string FacebookAccount { get; set; }

        [JsonProperty]
        public string YoutubeAccount { get; set; }

        [JsonProperty]
        public string GovtrackId { get; set; }

        [JsonProperty]
        public string CspanId { get; set; }

        [JsonProperty]
        public string VotesmartId { get; set; }

        [JsonProperty]
        public string IcpsrId { get; set; }

        [JsonProperty]
        public string CrpId { get; set; }

        [JsonProperty]
        public string GoogleEntityId { get; set; }

        [JsonProperty]
        public string FecCandidateId { get; set; }

        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string RssUrl { get; set; }

        [JsonProperty]
        public string ContactForm { get; set; }

        [JsonProperty]
        public bool InOffice { get; set; }

        [JsonProperty]
        public double? DwNominate { get; set; }

        [JsonProperty]
        public string IdealPoint { get; set; }

        [JsonProperty]
        public string Seniority { get; set; }

        [JsonProperty]
        public string NextElection { get; set; } // TODO parse int?

        [JsonProperty]
        public int? TotalVotes { get; set; }

        [JsonProperty]
        public int? MissedVotes { get; set; }

        [JsonProperty]
        public int? TotalPresent { get; set; }

        [JsonProperty]
        public DateTime LastUpdated { get; set; }

        [JsonProperty]
        public string OcdId { get; set; }

        [JsonProperty]
        public string Office { get; set; }

        [JsonProperty]
        public string Phone { get; set; }

        [JsonProperty]
        public string Fax { get; set; }

        [JsonProperty]
        public string State { get; set; }

        [JsonProperty]
        public string District { get; set; }

        [JsonProperty]
        public bool AtLarge { get; set; }

        [JsonProperty]
        public string Geoid { get; set; }

        [JsonProperty]
        public double MissedVotesPct { get; set; }

        [JsonProperty]
        public double VotesWithPartyPct { get; set; }
    }
}