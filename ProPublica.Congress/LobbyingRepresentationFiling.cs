using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class LobbyingRepresentationFiling
    {
        [JsonProperty]
        public string FilingDate { get; set; }

        [JsonProperty]
        public string ReportYear { get; set; }

        [JsonProperty]
        public string ReportType { get; set; }

        [JsonProperty]
        public string PdfUrl { get; set; }
    }
}