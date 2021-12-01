using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class StatementSubject
    {
        [JsonProperty]
        public string ApiUri { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Slug { get; set; }
    }
}