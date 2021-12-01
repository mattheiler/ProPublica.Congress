using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class ExpensesForMemberByCategoryResponse
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string MemberId { get; set; }

        [JsonProperty]
        public string MemberUri { get; set; }

        [JsonProperty]
        public string Category { get; set; }

        [JsonProperty]
        public List<ExpensesForMemberByCategory> Results { get; set; }
    }
}