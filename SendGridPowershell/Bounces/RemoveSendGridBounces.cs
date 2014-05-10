using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Bounces
{
    [Cmdlet("Remove", "SendGridBounces")]
    public class RemoveSendGridBounces : CmdletBase
    {
        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
