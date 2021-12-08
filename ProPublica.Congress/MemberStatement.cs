using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class MemberStatement
    {
        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string Date { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string StatementType { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string State { get; set; }

        [JsonProperty]
        public string Party { get; set; }

        [JsonProperty]
        public List<StatementSubject> Subjects { get; set; }
    }
}