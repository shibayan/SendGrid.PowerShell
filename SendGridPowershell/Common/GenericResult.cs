using Newtonsoft.Json;

namespace SendGrid.PowerShell.Common
{
    public class GenericResult
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("error")]
        public ErrorInfo Error { get; set; }

        [JsonIgnore]
        public bool IsSuccess
        {
            get { return Message == SuccessMessage; }
        }

        private const string SuccessMessage = "success";

        public class ErrorInfo
        {
            [JsonProperty("code")]
            public int Code { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }
        }
    }
}
