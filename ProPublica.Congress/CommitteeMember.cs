using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class CommitteeMember
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Party { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string Side { get; set; } // majority, minority

        [JsonProperty]
        public int? RankInParty { get; set; }

        [JsonProperty]
        public string State { get; set; }

        [JsonProperty]
        public string None { get; set; }

        [JsonProperty]
        public string BeginDate { get; set; }

        [JsonProperty]
        public string EndDate { get; set; }
    }
}