using System.Management.Automation;

using SendGrid.PowerShell.Common;
using SendGrid.PowerShell.TimeZone.Models;

namespace SendGrid.PowerShell.TimeZone
{
    [Cmdlet(VerbsCommon.Get, "SendGridTimeZone")]
    public class GetSendGridTimeZone : CmdletBase
    {
        protected override void ProcessRecord()
        {
            var result = Get<TimeZoneResult>("timezone", "get");

            WriteObject(result);
        }
    }
}
