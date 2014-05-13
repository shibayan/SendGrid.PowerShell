using System;
using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Statistics
{
    [Cmdlet(VerbsCommon.Get, "SendGridStats")]
    public class GetSendGridStats : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = false)]
        public int? Days { get; set; }

        [Parameter(Position = 1, Mandatory = false)]
        public DateTime? StartDate { get; set; }

        [Parameter(Position = 2, Mandatory = false)]
        public DateTime? EndDate { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public bool Aggregate { get; set; }

        [Parameter(Position = 4, Mandatory = false)]
        public string Category { get; set; }

        protected override void ProcessRecord()
        {
            var result = Get<StatsResult[]>("stats", "get", new
            {
                days = Days,
                start_date = StartDate.HasValue ? StartDate.Value.ToString("yyyy-MM-dd") : null,
                end_date = EndDate.HasValue ? EndDate.Value.ToString("yyyy-MM-dd") : null,
                aggregate = Aggregate ? 1 : 0,
                category = Category
            });

            WriteObject(result, true);
        }
    }
}
