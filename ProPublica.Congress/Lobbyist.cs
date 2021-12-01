using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class Lobbyist
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty("covered_position")]
        public string Position { get; set; }
    }
}