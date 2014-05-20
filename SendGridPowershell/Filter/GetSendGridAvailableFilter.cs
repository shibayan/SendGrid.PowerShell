using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Filter
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
