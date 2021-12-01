using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class Statement
    {
        [JsonProperty]
        public int Congress { get; set; }

        [JsonProperty]
        public string MemberId { get; set; }

        [JsonProperty]
        public string MemberUri { get; set; }

        [JsonProperty("name")]
        public string MemberName { get; set; }

        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string Date { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string StatementType { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string State { get; set; }

        [JsonProperty]
        public string Party { get; set; }

        [JsonProperty]
        public StatementSubject[] Subjects { get; set; }
    }
}