using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class MemberCommittee
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Code { get; set; }

        [JsonProperty]
        public string ApiUri { get; set; }

        [JsonProperty]
        public string Side { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public int? RankInParty { get; set; }

        [JsonProperty]
        public string BeginDate { get; set; }

        [JsonProperty]
        public string EndDate { get; set; }
    }
}