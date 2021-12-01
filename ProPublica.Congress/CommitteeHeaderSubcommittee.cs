using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class CommitteeHeaderSubcommittee
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }
    }
}