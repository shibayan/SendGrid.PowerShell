using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Mail
{
    [Cmdlet(VerbsCommunications.Send, "SendGridMail")]
    public class SendSendGridMail : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true)]
        public string To { get; set; }

        [Parameter(Position = 1, Mandatory = true)]
        public string From { get; set; }

        [Parameter(Position = 2, Mandatory = true)]
        public string Subject { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public string Text { get; set; }

        [Parameter(Position = 4, Mandatory = false)]
        public string Html { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("mail", "send", new
            {
                to = To,
                from = From,
                subject = Subject,
                text = Text,
                html = Html
            });

            WriteObject(result);
        }
    }
}
