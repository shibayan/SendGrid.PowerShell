using System;

using Newtonsoft.Json;

namespace SendGrid.PowerShell.InvalidEmails.Models
{
    public class InvalidEmailsResult
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
