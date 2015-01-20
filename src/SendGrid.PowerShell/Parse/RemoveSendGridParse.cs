using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Parse
{
    [Cmdlet(VerbsCommon.Remove, "SendGridParse")]
    public class RemoveSendGridParse : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Hostname { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("parse", "delete", new { hostname = Hostname });

            WriteObject(result);
        }
    }
}
