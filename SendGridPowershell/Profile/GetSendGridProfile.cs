using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Profile
{
    [Cmdlet("Get", "SendGridProfile")]
    public class GetSendGridProfile : CmdletBase
    {
        protected override void ProcessRecord()
        {
            var result = Get<ProfileResult[]>("profile", "get");

            WriteObject(result, true);
        }
    }
}