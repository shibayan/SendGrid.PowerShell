using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Account
{
    [Cmdlet(VerbsCommon.Add, "SendGridAccount")]
    public class AddSendGridAccount : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Username { get; set; }

        [Parameter(Position = 1, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Password { get; set; }

        protected override void ProcessRecord()
        {
            ApiUser = Username;
            ApiKey = Password;

            WriteWarning(string.Format("Account \"{0}\" has been added", Username));
        }
    }
}
