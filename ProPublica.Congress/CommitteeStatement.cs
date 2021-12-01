using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class CommitteeStatement
    {
        [JsonProperty]
        public int Congress { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string CommitteeId { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string ApiUri { get; set; }

        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string Date { get; set; }

        [JsonProperty]
        public string CreatedAt { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string StatementType { get; set; }

        [JsonProperty]
        public string Party { get; set; }
    }
}