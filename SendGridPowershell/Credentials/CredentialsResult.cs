using Newtonsoft.Json;

namespace SendGridPowershell.Credentials
{
    public class CredentialsResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permissions")]
        public CredentialsPermissionResult Permissions { get; set; }
    }

    public class CredentialsPermissionResult
    {
        [JsonProperty("api")]
        public bool Api { get; set; }

        [JsonProperty("email")]
        public bool Email { get; set; }

        [JsonProperty("web")]
        public bool Web { get; set; }
    }
}
