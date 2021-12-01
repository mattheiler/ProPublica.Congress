using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class Vote
    {
        [JsonProperty]
        public int Congress { get; set; }

        [JsonProperty]
        public int Session { get; set; }

        [JsonProperty]
        public int RollCall { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<VotePosition> Positions { get; set; }
    }
}