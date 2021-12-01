using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class NominationAction
    {
        [JsonProperty]
        public string Date { get; set; }

        [JsonProperty]
        public string Description { get; set; }
    }
}