using Newtonsoft.Json;

namespace ProPublica.Congress
{
    public class ExpensesForMemberByCategory
    {
        [JsonProperty]
        public int Year { get; set; }

        [JsonProperty]
        public int Quarter { get; set; }

        [JsonProperty]
        public double Amount { get; set; }

        [JsonProperty]
        public double YearToDate { get; set; }

        [JsonProperty]
        public double ChangeFromPreviousQuarter { get; set; }
    }
}