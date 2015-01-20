using System;
using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Statistics
{
    [Cmdlet(VerbsCommon.Get, "SendGridAdvancedStats")]
    public class GetSendGridAdvancedStats : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = true)]
        public string DateType { get; set; }

        [Parameter(Position = 1, Mandatory = true)]
        public DateTime? StartDate { get; set; }

        [Parameter(Position = 2, Mandatory = false)]
        public DateTime? EndDate { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public string Metric { get; set; }

        [Parameter(Position = 4, Mandatory = false)]
        public string Category { get; set; }

        [Parameter(Position = 5, Mandatory = false)]
        public string AggregatedBy { get; set; }

        [Parameter(Position = 6, Mandatory = false)]
        public string Country { get; set; }

        protected override void ProcessRecord()
        {
            throw new PSNotImplementedException();
        }
    }
}
