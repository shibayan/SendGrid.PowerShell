using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Blocks
{
    [Cmdlet("Remove", "SendGridBlocks")]
    public class RemoveSendGridBlocks : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
