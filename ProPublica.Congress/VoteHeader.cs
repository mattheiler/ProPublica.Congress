using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class VoteHeader
    {
        [JsonProperty]
        public int Congress { get; set; }

        [JsonProperty]
        public int Session { get; set; }

        [JsonProperty]
        public int RollCall { get; set; }
    }
}