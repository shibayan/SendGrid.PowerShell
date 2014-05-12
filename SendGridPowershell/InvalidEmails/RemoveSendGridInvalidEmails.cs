using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.InvalidEmails
{
    [Cmdlet("Remove", "SendGridInvalidEmails")]
    public class RemoveSendGridInvalidEmails : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("blocks", "delete", new { email = Email });

            WriteObject(result);
        }
    }
}
