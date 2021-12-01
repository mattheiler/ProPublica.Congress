using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class NominationByType
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Uri { get; set; }

        [JsonProperty]
        public string DateReceived { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public string NomineeState { get; set; }

        [JsonProperty]
        public string CommitteeId { get; set; }

        [JsonProperty]
        public string CommitteeUri { get; set; }

        [JsonProperty]
        public string LastActionDate { get; set; }

        [JsonProperty]
        public string LastActionText { get; set; }

        [JsonProperty]
        public string Organization { get; set; }

        [JsonProperty]
        public string Status { get; set; }
    }
}