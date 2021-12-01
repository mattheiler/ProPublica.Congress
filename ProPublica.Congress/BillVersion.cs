using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class BillVersion
    {
        [JsonProperty]
        public string Status { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressDotGovUrl { get; set; }
    }
}