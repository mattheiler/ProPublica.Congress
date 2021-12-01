using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class Role
    {
        [JsonProperty]
        public int Congress { get; set; } // TODO cant this be an int?

        [JsonProperty]
        public string Chamber { get; set; } // TODO convert to enum?

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string ShortTitle { get; set; }

        [JsonProperty]
        public string State { get; set; } // TODO convert to enum?

        [JsonProperty]
        public string Party { get; set; } // TODO convert to enum?

        [JsonProperty]
        public string LeadershipRole { get; set; }

        [JsonProperty]
        public string FecCandidateId { get; set; }

        [JsonProperty]
        public string Seniority { get; set; }

        [JsonProperty]
        public string District { get; set; }

        [JsonProperty]
        public bool AtLarge { get; set; }

        [JsonProperty]
        public string OcdId { get; set; }

        [JsonProperty]
        public DateTime StartDate { get; set; }

        [JsonProperty]
        public DateTime? EndDate { get; set; }

        [JsonProperty]
        public string Office { get; set; }

        [JsonProperty]
        public string Phone { get; set; }

        [JsonProperty]
        public string Fax { get; set; }

        [JsonProperty]
        public string ContactForm { get; set; }

        [JsonProperty]
        public int? BillsSponsored { get; set; }

        [JsonProperty]
        public int? BillsCosponsored { get; set; }

        [JsonProperty]
        public double? MissedVotesPct { get; set; }

        [JsonProperty]
        public double? VotesWithPartyPct { get; set; }

        [JsonProperty]
        public IList<MemberCommittee> Committees { get; set; }

        [JsonProperty]
        public IList<MemberSubcommittee> Subcommittees { get; set; }
    }
}