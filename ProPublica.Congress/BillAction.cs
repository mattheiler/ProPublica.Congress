using System;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class BillAction
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty("action_type")]
        public string Type { get; set; }

        [JsonProperty("datetime")]
        public DateTime? Date { get; set; }

        [JsonProperty]
        public string Description { get; set; }
    }
}