using System;

using Newtonsoft.Json;

namespace SendGridPowershell.Statistics
{
    public class StatsResult
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("unsubscribes")]
        public int Unsubscribes { get; set; }

        [JsonProperty("invalid_email")]
        public int InvalidEmail { get; set; }

        [JsonProperty("bounces")]
        public int Bounces { get; set; }

        [JsonProperty("repeat_unsubscribes")]
        public int RepeatUnsubscribes { get; set; }

        [JsonProperty("unique_clicks")]
        public int UniqueClicks { get; set; }

        [JsonProperty("blocked")]
        public int Blocked { get; set; }

        [JsonProperty("spam_drop")]
        public int SpamDrop { get; set; }

        [JsonProperty("repeat_bounces")]
        public int RepeatBounces { get; set; }

        [JsonProperty("repeat_spamreports")]
        public int RepeatSpamreports { get; set; }

        [JsonProperty("requests")]
        public int Requests { get; set; }

        [JsonProperty("spamreports")]
        public int Spamreports { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("opens")]
        public int Opens { get; set; }

        [JsonProperty("unique_opens")]
        public int UniqueOpens { get; set; }
    }
}
