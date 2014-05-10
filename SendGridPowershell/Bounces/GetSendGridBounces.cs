using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Bounces
{
    [Cmdlet("Get", "SendGridBounces")]
    public class GetSendGridBounces : CmdletBase
    {
        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
