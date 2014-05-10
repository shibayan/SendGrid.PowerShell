using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.SpamReports
{
    [Cmdlet("Get", "SendGridSpamReports")]
    public class GetSendGridSpamReports : CmdletBase
    {
        [Parameter(Position = 1, Mandatory = false)]
        public int? Days { get; set; }

        [Parameter(Position = 2, Mandatory = false)]
        public string StartDate { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public string EndDate { get; set; }

        [Parameter(Position = 4, Mandatory = false)]
        public int? Limit { get; set; }

        [Parameter(Position = 5, Mandatory = false)]
        public int? Offset { get; set; }

        [Parameter(Position = 6, Mandatory = false)]
        public string Email { get; set; }

        protected override void ProcessRecord()
        {
            var result = Get<SpamReportsResult[]>("spamreports", "get", new
            {
                date = 1,
                days = Days,
                start_date = StartDate,
                end_date = EndDate,
                limit = Limit,
                offset = Offset,
                email = Email
            });

            WriteObject(result);
        }
    }
}
