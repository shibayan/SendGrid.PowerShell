using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Account
{
    [Cmdlet("Add", "SendGridAccount")]
    public class AddSendGridAccount : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Username { get; set; }

        [Parameter(Position = 2, Mandatory = true)]
        public string Password { get; set; }

        protected override void ProcessRecord()
        {
            ApiUser = Username;
            ApiKey = Password;

            WriteVerbose(string.Format("Account \"{0}\" has been added", Username));
        }
    }
}
