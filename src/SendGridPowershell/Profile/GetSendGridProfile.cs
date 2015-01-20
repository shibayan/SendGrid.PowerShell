using System.Management.Automation;

using SendGrid.PowerShell.Common;
using SendGrid.PowerShell.Profile.Models;

namespace SendGrid.PowerShell.Profile
{
    [Cmdlet(VerbsCommon.Get, "SendGridProfile")]
    public class GetSendGridProfile : CmdletBase
    {
        protected override void ProcessRecord()
        {
            var result = Get<ProfileResult[]>("profile", "get");

            WriteObject(result, true);
        }
    }
}