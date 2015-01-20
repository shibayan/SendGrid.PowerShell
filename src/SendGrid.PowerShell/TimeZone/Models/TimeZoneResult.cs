using Newtonsoft.Json;

namespace SendGrid.PowerShell.TimeZone.Models
{
    public class TimeZoneResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }
}
