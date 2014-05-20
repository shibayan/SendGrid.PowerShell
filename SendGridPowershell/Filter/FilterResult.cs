using Newtonsoft.Json;

namespace SendGridPowershell.Filter
{
    public class FilterResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("activated")]
        public bool Activated { get; set; }
    }
}
