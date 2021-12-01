using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ProPublica.Congress
{
    public class MemberVote
    {
        [JsonProperty]
        public string MemberId { get; set; }

        [JsonProperty]
        public string Congress { get; set; }

        [JsonProperty]
        public string Chamber { get; set; }

        [JsonProperty]
        public string Session { get; set; }

        [JsonProperty]
        public string RoleCall { get; set; }

        [JsonProperty]
        public string VoteUrl { get; set; }

        [JsonProperty]
        public MemberVoteBill Bill { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public string Question { get; set; }

        [JsonProperty]
        public string Result { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty]
        public MemberVotePosition Position { get; set; }
    }
}