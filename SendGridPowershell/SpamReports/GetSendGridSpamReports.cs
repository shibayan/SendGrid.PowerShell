using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.SpamReports
{
    [Cmdlet("Get", "SendGridSpamReports")]
    public class GetSendGridSpamReports : CmdletBase
    {
        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
