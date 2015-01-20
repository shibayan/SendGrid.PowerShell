using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Filter
{
    [Cmdlet("Enable", "SendGridFilter")]
    public class EnableSendGridFilter : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        protected override void ProcessRecord()
        {
            var result = Get<GenericResult>("filter", "activate", new
            {
                name = Name
            });

            WriteObject(result);
        }
    }
}
