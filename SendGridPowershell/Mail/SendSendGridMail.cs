using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Mail
{
    [Cmdlet("Send", "SendGridMail")]
    public class SendSendGridMail : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string To { get; set; }

        [Parameter(Position = 2, Mandatory = true)]
        public string From { get; set; }

        [Parameter(Position = 3, Mandatory = true)]
        public string Subject { get; set; }

        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
