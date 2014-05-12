using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.SpamReports
{
    [Cmdlet(VerbsCommon.Remove, "SendGridSpamReports")]
    public class RemoveSendGridSpamReports : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("spamreports", "delete", new { email = Email });

            WriteObject(result);
        }
    }
}
