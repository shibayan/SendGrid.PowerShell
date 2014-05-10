using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.SpamReports
{
    [Cmdlet("Remove", "SendGridSpamReports")]
    public class RemoveSendGridSpamReports : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
