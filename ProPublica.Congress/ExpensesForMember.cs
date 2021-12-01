using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class ExpensesForMember
    {
        [JsonProperty]
        public string Category { get; set; }

        [JsonProperty]
        public string CategorySlug { get; set; }

        [JsonProperty]
        public double Amount { get; set; }

        [JsonProperty]
        public double YearToDate { get; set; }

        [JsonProperty]
        public double ChangeFromPreviousQuarter { get; set; }
    }
}