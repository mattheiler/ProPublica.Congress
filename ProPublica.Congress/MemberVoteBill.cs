using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class MemberVoteBill
    {
        [JsonProperty]
        public string BillId { get; set; }

        [JsonProperty]
        public string Number { get; set; }

        [JsonProperty]
        public string BillUri { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string LatestAction { get; set; }
    }
}