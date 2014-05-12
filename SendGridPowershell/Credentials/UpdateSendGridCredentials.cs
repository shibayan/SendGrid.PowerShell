using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Credentials
{
    [Cmdlet("Update", "SendGridCredentials")]
    public class UpdateSendGridCredentials : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Username { get; set; }

        [Parameter(Position = 2, Mandatory = true)]
        public string Password { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("credentials", "edit", new
            {
                username = Username,
                password = Password
            });

            WriteObject(result);
        }
    }
}
