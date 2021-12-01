using System;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class BillCosponsor
    {
        [JsonProperty("cosponsor_id")]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty("cosponsor_title")]
        public string Title { get; set; }

        [JsonProperty("cosponsor_state")]
        public string State { get; set; }

        [JsonProperty("cosponsor_party")]
        public string Party { get; set; }

        [JsonProperty("cosponsor_uri")]
        public string Uri { get; set; }

        [JsonProperty("date")]
        public DateTime? Sponsored { get; set; }
    }
}