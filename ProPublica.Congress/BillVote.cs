using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class BillVote
    {
        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string Date { get; set; }

        [JsonProperty]
        public string Time { get; set; }

        [JsonProperty]
        public int RollCall { get; set; }

        [JsonProperty]
        public string Question { get; set; }

        [JsonProperty]
        public string Result { get; set; }

        [JsonProperty]
        public int TotalYes { get; set; }

        [JsonProperty]
        public int TotalNo { get; set; }

        [JsonProperty]
        public int TotalNotVoting { get; set; }

        [JsonProperty]
        public string ApiUrl { get; set; }
    }
}