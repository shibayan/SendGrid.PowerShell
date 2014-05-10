using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Blocks
{
    [Cmdlet("Get", "SendGridBlocks")]
    public class GetSendGridBlocks : CmdletBase
    {
        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
