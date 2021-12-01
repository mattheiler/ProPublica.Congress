﻿using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class LobbyingRepresentationDetails
    {
        [JsonProperty("inhouse")]
        public bool InHouse { get; set; }

        [JsonProperty]
        public string SignedDate { get; set; }

        [JsonProperty]
        public string EffectiveDate { get; set; }

        [JsonProperty("xml_filename")]
        public string XmlFileName { get; set; }

        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty("specific_issues")]
        public string[] Issues { get; set; }

        [JsonProperty]
        public LobbyingRepresentationFiling[] Filings { get; set; }

        [JsonProperty]
        public string ReportType { get; set; }

        [JsonProperty]
        public string ReportYear { get; set; }

        [JsonProperty]
        public string SenateId { get; set; }

        [JsonProperty]
        public string HouseId { get; set; }

        [JsonProperty]
        public LobbyingClient LobbyingClient { get; set; }

        [JsonProperty]
        public LobbyingRegistrant LobbyingRegistrant { get; set; }

        [JsonProperty]
        public Lobbyist[] Lobbyists { get; set; }
    }
}