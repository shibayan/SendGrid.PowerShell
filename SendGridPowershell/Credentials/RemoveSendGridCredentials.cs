using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Credentials
{
    [Cmdlet("Remove", "SendGridCredentials")]
    public class RemoveSendGridCredentials : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Username { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("credentials", "delete", new
            {
                username = Username
            });

            WriteObject(result);
        }
    }
}
