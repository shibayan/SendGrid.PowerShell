using System.Management.Automation;

using SendGrid.PowerShell.Common;
using SendGrid.PowerShell.Filter.Models;

namespace SendGrid.PowerShell.Filter
{
    [Cmdlet(VerbsCommon.Get, "SendGridAvailableFilter")]
    public class GetSendGridAvailableFilter : CmdletBase
    {
        protected override void ProcessRecord()
        {
            var result = Get<FilterResult[]>("filter", "getavailable");

            WriteObject(result);
        }
    }
}
