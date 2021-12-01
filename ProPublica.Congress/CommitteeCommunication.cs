using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class CommitteeCommunication
    {
        [JsonProperty("communication_id")]
        public string Id { get; set; }

        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string Date { get; set; }

        [JsonProperty]
        public string Text { get; set; }

        [JsonProperty]
        public string Category { get; set; }

        [JsonProperty]
        public int Congress { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string RequirementNumber { get; set; }

        [JsonProperty]
        public string RequirementUrl { get; set; }

        [JsonProperty]
        public string CommitteeCode { get; set; }

        [JsonProperty]
        public string CommitteeName { get; set; }
    }
}