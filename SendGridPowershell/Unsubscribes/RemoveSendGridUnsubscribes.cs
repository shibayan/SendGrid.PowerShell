using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Unsubscribes
{
    [Cmdlet("Remove", "SendGridUnsubscribes")]
    public class RemoveSendGridUnsubscribes : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("unsubscribes", "delete", new { email = Email });

            WriteObject(result);
        }
    }
}
