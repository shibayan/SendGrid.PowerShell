using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.InvalidEmails
{
    [Cmdlet("Get", "SendGridInvalidEmails")]
    public class GetSendGridInvalidEmails : CmdletBase
    {
        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
