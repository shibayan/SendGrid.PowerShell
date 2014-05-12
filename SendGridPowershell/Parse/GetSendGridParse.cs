using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Parse
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
