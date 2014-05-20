using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Filter
{
    [Cmdlet("Disable", "SendGridFilter")]
    public class DisableSendGridFilter : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            var result = Get<GenericResult>("filter", "deactivate", new
            {
                name = Name
            });

            WriteObject(result);
        }
    }
}
