using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Parse
{
    [Cmdlet("Set", "SendGridParse")]
    public class SetSendGridParse : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = true)]
        public string Hostname { get; set; }

        [Parameter(Position = 2, Mandatory = true)]
        public string Url { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public bool SpamCheck { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("parse", "set", new
            {
                hostname = Hostname,
                url = Url,
                spam_check = SpamCheck ? 1 : 0
            });

            WriteObject(result);
        }
    }
}
