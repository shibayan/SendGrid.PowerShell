using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Unsubscribes
{
    [Cmdlet(VerbsCommon.Remove, "SendGridUnsubscribes")]
    public class RemoveSendGridUnsubscribes : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("unsubscribes", "delete", new { email = Email });

            WriteObject(result);
        }
    }
}
