using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class Committee
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Congress { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string Chair { get; set; }

        [JsonProperty]
        public string ChairId { get; set; }

        [JsonProperty]
        public string ChairParty { get; set; }

        [JsonProperty]
        public string ChairState { get; set; }

        [JsonProperty]
        public string RankingMemberId { get; set; }

        [JsonProperty]
        public List<CommitteeMember> CurrentMembers { get; set; }

        [JsonProperty]
        public List<CommitteeMember> FormerMembers { get; set; }

        [JsonProperty]
        public List<CommitteeSubcommittee> Subcommittees { get; set; }
    }
}