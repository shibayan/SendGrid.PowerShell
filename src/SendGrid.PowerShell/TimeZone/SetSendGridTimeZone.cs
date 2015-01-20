using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.TimeZone
{
    [Cmdlet(VerbsCommon.Set, "SendGridTimeZone")]
    public class SetSendGridTimeZone : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string TimeZone { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("timezone", "edit", new
            {
                timezone = TimeZone
            });

            WriteObject(result);
        }
    }
}
