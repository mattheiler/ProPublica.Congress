using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class ExpensesByCategory
    {
        [JsonProperty]
        public int Year { get; set; }

        [JsonProperty]
        public int Quarter { get; set; }

        [JsonProperty]
        public string MemberId { get; set; }

        [JsonProperty("name")]
        public string MemberName { get; set; }

        [JsonProperty]
        public string MemberUri { get; set; }

        [JsonProperty]
        public double Amount { get; set; }

        [JsonProperty]
        public double YearToDate { get; set; }

        [JsonProperty]
        public double ChangeFromPreviousQuarter { get; set; }
    }
}