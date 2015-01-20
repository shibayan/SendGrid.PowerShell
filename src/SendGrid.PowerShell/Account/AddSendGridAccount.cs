using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Account
{
    [Cmdlet(VerbsCommon.Add, "SendGridAccount")]
    public class AddSendGridAccount : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        [ValidateNotNull]
        public PSCredential Credential { get; set; }

        protected override void ProcessRecord()
        {
            ApiCredential = Credential.GetNetworkCredential();

            WriteWarning(string.Format("Account \"{0}\" has been added", ApiCredential.UserName));
        }
    }
}
