using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Unsubscribes
{
    [Cmdlet(VerbsCommon.Add, "SendGridUnsubscribes")]
    public class AddSendGridUnsubscribes : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("unsubscribes", "add", new { email = Email });

            WriteObject(result);
        }
    }
}
