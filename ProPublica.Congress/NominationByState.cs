using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class NominationByState
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Uri { get; set; }

        [JsonProperty]
        public string DateReceived { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public string NomineeState { get; set; }

        [JsonProperty]
        public string Committee { get; set; }

        [JsonProperty]
        public string LastActionDate { get; set; }

        [JsonProperty]
        public string Status { get; set; }
    }
}