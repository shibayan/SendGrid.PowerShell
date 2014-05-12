using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Credentials
{
    [Cmdlet("Get", "SendGridCredentials")]
    public class GetSendGridCredentials : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = false)]
        public string Username { get; set; }

        protected override void ProcessRecord()
        {
            var result = Get<CredentialsResult[]>("credentials", "get", new
            {
                username = Username
            });

            WriteObject(result, true);
        }
    }
}
