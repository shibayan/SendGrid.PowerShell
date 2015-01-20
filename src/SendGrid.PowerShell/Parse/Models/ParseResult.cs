using Newtonsoft.Json;

namespace SendGrid.PowerShell.Parse.Models
{
    public class ParseResult
    {
        [JsonProperty("parse")]
        public ParseInfo[] Parse { get; set; }
    }

    public class ParseInfo
    {
        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("spam_check")]
        public bool SpamCheck { get; set; }
    }
}