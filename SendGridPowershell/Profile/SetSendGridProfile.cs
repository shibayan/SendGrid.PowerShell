using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Profile
{
    [Cmdlet("Set", "SendGridProfile")]
    public class SetSendGridProfile : CmdletBase
    {
        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
