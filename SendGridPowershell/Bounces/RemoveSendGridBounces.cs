using System;
using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Bounces
{
    [Cmdlet(VerbsCommon.Remove, "SendGridBounces")]
    public class RemoveSendGridBounces : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = false)]
        public DateTime? StartDate { get; set; }

        [Parameter(Position = 1, Mandatory = false)]
        public DateTime? EndDate { get; set; }

        [Parameter(Position = 2, Mandatory = false)]
        public string Type { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public string Email { get; set; }

        [Parameter(Position = 4, Mandatory = false)]
        public bool? DeleteAll { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("bounces", "delete", new
            {
                start_date = StartDate.HasValue ? StartDate.Value.ToString("yyyy-MM-dd") : null,
                end_date = EndDate.HasValue ? EndDate.Value.ToString("yyyy-MM-dd") : null,
                type = Type,
                email = Email,
                delete_all = (DeleteAll ?? false) ? "1" : null
            });

            WriteObject(result);
        }
    }
}
