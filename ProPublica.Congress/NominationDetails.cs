using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class NominationDetails
    {
        [JsonProperty]
        public int Congress { get; set; }

        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string DateReceived { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public string NomineeState { get; set; }

        [JsonProperty]
        public string CommitteeUri { get; set; }

        [JsonProperty]
        public string LastActionDate { get; set; }

        [JsonProperty]
        public string Status { get; set; }

        [JsonProperty]
        public List<NominationAction> Actions { get; set; }

        [JsonProperty]
        public List<NominationVote> Votes { get; set; }
    }
}