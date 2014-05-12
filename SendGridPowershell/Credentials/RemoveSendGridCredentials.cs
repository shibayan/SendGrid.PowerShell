using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Credentials
{
    [Cmdlet(VerbsCommon.Remove, "SendGridCredentials")]
    public class RemoveSendGridCredentials : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
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
