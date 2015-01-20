using System.Management.Automation;

using SendGrid.PowerShell.Common;
using SendGrid.PowerShell.Credentials.Models;

namespace SendGrid.PowerShell.Credentials
{
    [Cmdlet(VerbsCommon.Get, "SendGridCredentials")]
    public class GetSendGridCredentials : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
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
