using System;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class BillAmendment
    {
        [JsonProperty("amendment_number")]
        public string Number { get; set; }

        [JsonProperty]
        public string Slug { get; set; }

        [JsonProperty]
        public string SponsorTitle { get; set; }

        [JsonProperty("sponsor")]
        public string SponsorName { get; set; }

        [JsonProperty]
        public string SponsorId { get; set; }

        [JsonProperty]
        public string SponsorUri { get; set; }

        [JsonProperty]
        public string SponsorParty { get; set; }

        [JsonProperty]
        public string SponsorState { get; set; }

        [JsonProperty("introduced_date")]
        public DateTime? Introduced { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string CongressDotGovUrl { get; set; }

        [JsonProperty]
        public DateTime? LatestMajorActionDate { get; set; }

        [JsonProperty]
        public string LatestMajorAction { get; set; }
    }
}