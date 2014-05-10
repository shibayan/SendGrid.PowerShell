using System.ComponentModel;
using System.Management.Automation;

namespace SendGridPowershell
{
    [RunInstaller(true)]
    public class SendGridSnapIn : PSSnapIn
    {
        public override string Description
        {
            get { return "SendGrid PowerShell Cmdlets."; }
        }

        public override string Name
        {
            get { return "SendGridPowershell"; }
        }

        public override string Vendor
        {
            get { return "shiba-yan"; }
        }
    }
}
