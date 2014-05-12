using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Credentials
{
    [Cmdlet(VerbsCommon.Set, "SendGridCredentials")]
    public class SetSendGridCredentials : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Username { get; set; }

        [Parameter(Position = 1, Mandatory = true)]
        [ValidateNotNullOrEmpty]
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
