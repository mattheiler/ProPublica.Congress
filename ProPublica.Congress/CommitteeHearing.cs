using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class CommitteeHearing
    {
        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string Committee { get; set; }

        [JsonProperty]
        public string CommitteeCode { get; set; }

        [JsonProperty]
        public string ApiUri { get; set; }

        [JsonProperty]
        public string Date { get; set; }

        [JsonProperty]
        public string Time { get; set; }

        [JsonProperty]
        public string Location { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public string[] BillIds { get; set; }

        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string MeetingType { get; set; }
    }
}