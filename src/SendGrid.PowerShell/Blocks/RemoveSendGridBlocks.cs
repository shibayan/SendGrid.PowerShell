using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Blocks
{
    [Cmdlet(VerbsCommon.Remove, "SendGridBlocks")]
    public class RemoveSendGridBlocks : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("blocks", "delete", new { email = Email });

            WriteObject(result);
        }
    }
}
