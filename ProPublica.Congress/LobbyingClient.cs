using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class LobbyingClient
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty("general_description")]
        public string Description { get; set; }
    }
}