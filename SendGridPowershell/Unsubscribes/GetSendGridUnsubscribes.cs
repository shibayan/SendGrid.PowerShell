using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Unsubscribes
{
    [Cmdlet("Get", "SendGridUnsubscribes")]
    public class GetSendGridUnsubscribes : CmdletBase
    {
        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
