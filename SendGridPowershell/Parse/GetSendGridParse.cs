using System.Management.Automation;

using SendGrid.PowerShell.Common;
using SendGrid.PowerShell.Parse.Models;

namespace SendGrid.PowerShell.Parse
{
    [Cmdlet(VerbsCommon.Get, "SendGridParse")]
    public class GetSendGridParse : CmdletBase
    {
        protected override void ProcessRecord()
        {
            var result = Get<ParseResult>("parse", "get");

            WriteObject(result.Parse, true);
        }
    }
}
