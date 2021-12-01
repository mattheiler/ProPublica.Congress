using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class ExpensesForMemberResponse
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string MemberId { get; set; }

        [JsonProperty]
        public string MemberUri { get; set; }

        [JsonProperty]
        public int Year { get; set; }

        [JsonProperty]
        public int Quarter { get; set; }

        [JsonProperty]
        public List<ExpensesForMember> Results { get; set; }
    }
}