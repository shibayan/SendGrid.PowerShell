using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.InvalidEmails
{
    [Cmdlet("Remove", "SendGridInvalidEmails")]
    public class RemoveSendGridInvalidEmails : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
