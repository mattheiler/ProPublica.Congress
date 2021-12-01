using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class Bill
    {
        [JsonProperty("bill_id")]
        public string Id { get; set; }

        [JsonProperty("bill_slug")]
        public string Slug { get; set; }

        [JsonProperty]
        public string Congress { get; set; }

        [JsonProperty("bill")]
        public string Code { get; set; }

        [JsonProperty("bill_type")]
        public string Type { get; set; }

        [JsonProperty]
        public string Number { get; set; }

        [JsonProperty("bill_uri")]
        public string Uri { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string ShortTitle { get; set; }

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

        [JsonProperty]
        public string GpoPdfUri { get; set; }

        [JsonProperty("congressdotgov_url")]
        public string CongressDotGovUrl { get; set; }

        [JsonProperty("govtrack_url")]
        public string GovTrackUrl { get; set; }

        [JsonProperty]
        public DateTime? IntroducedDate { get; set; }

        [JsonProperty]
        public bool Active { get; set; }

        [JsonProperty]
        public DateTime? LastVote { get; set; }

        [JsonProperty]
        public DateTime? HousePassage { get; set; }

        [JsonProperty]
        public DateTime? SenatePassage { get; set; }

        [JsonProperty]
        public DateTime? Enacted { get; set; }

        [JsonProperty]
        public DateTime? Vetoed { get; set; }

        [JsonProperty]
        public string Cosponsors { get; set; }

        //[JsonProperty]
        //public IReadOnlyDictionary<string, int> CosponsorsByParty { get; set; }

        [JsonProperty]
        public string WithdrawnCosponsors { get; set; }

        [JsonProperty]
        public string PrimarySubject { get; set; }

        [JsonProperty]
        public string Committees { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<string> CommitteeCodes { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<string> SubcommitteeCodes { get; set; }

        [JsonProperty]
        public DateTime? LatestMajorActionDate { get; set; }

        [JsonProperty]
        public string LatestMajorAction { get; set; }

        [JsonProperty]
        public DateTime? HousePassageVote { get; set; }

        [JsonProperty]
        public DateTime? SenatePassageVote { get; set; }

        [JsonProperty]
        public string Summary { get; set; }

        [JsonProperty]
        public string SummaryShort { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<BillVersion> Versions { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<BillAction> Actions { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<BillVote> Votes { get; set; }
    }
}