using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class Member
    {
        [JsonProperty("member_id")]
        public string Id { get; set; }

        [JsonProperty]
        public string FirstName { get; set; }

        [JsonProperty]
        public string MiddleName { get; set; }

        [JsonProperty]
        public string LastName { get; set; }

        [JsonProperty]
        public string Suffix { get; set; }

        [JsonProperty]
        public DateTime? DateOfBirth { get; set; }

        [JsonProperty]
        public string Gender { get; set; } // TODO enum

        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string TimesTopicsUrl { get; set; }

        [JsonProperty]
        public string TimesTag { get; set; }

        [JsonProperty]
        public string GovtrackId { get; set; }

        [JsonProperty]
        public string CspanId { get; set; }

        [JsonProperty]
        public string VotesmartId { get; set; }

        [JsonProperty]
        public string IcpsrId { get; set; }

        [JsonProperty]
        public string LisId { get; set; }

        [JsonProperty]
        public string TwitterAccount { get; set; }

        [JsonProperty]
        public string FacebookAccount { get; set; }

        [JsonProperty]
        public string YoutubeAccount { get; set; }

        [JsonProperty]
        public string CrpId { get; set; }

        [JsonProperty]
        public string GoogleEntityId { get; set; }

        [JsonProperty]
        public string RssUrl { get; set; }

        [JsonProperty]
        public bool InOffice { get; set; }

        [JsonProperty]
        public string CurrentParty { get; set; } // TODO enum

        [JsonProperty]
        public string MostRecentVote { get; set; }

        [JsonProperty]
        public List<Role> Roles { get; set; }
    }
}