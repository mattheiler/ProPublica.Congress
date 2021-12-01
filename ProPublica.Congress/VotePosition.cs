using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class VotePosition
    {
        [JsonProperty]
        public string MemberId { get; set; }

        [JsonProperty("vote_position")]
        public string Position { get; set; }
    }
}