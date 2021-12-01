using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class BillHeader
    {
        [JsonProperty]
        public string Congress { get; set; }

        [JsonProperty]
        public string BillId { get; set; }

        [JsonProperty]
        public string BillSlug { get; set; }

        [JsonProperty]
        public string BillType { get; set; }

        [JsonProperty]
        public string Number { get; set; }

        [JsonProperty]
        public string BillUri { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string ShortTitle { get; set; }

        [JsonProperty]
        public string SponsorTitle { get; set; }

        [JsonProperty]
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

        [JsonProperty]
        public string Committees { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<string> CommitteeCodes { get; set; }

        [JsonProperty]
        public IReadOnlyCollection<string> SubcommitteeCodes { get; set; }

        [JsonProperty]
        public string PrimarySubject { get; set; }

        [JsonProperty]
        public DateTime? LatestMajorActionDate { get; set; }

        [JsonProperty]
        public string LatestMajorAction { get; set; }

        [JsonProperty]
        public string Summary { get; set; }

        [JsonProperty]
        public string SummaryShort { get; set; }
    }
}