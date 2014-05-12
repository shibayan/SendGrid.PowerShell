using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Parse
{
    [Cmdlet("Remove", "SendGridParse")]
    public class RemoveSendGridParse : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string Hostname { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("parse", "delete", new { hostname = Hostname });

            WriteObject(result);
        }
    }
}
