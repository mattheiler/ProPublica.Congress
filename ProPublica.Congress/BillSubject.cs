using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class BillSubject
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty("url_name")]
        public string Slug { get; set; }
    }
}