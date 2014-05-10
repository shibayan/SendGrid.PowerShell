using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Unsubscribes
{
    [Cmdlet("Add", "SendGridUnsubscribes")]
    public class AddSendGridUnsubscribes : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
