using System.Management.Automation;

using SendGridPowershell.Common;

namespace SendGridPowershell.Bounces
{
    [Cmdlet(VerbsCommon.Remove, "SendGridBounces")]
    public class RemoveSendGridBounces : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = false)]
        public string StartDate { get; set; }

        [Parameter(Position = 1, Mandatory = false)]
        public string EndDate { get; set; }

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
                start_date = StartDate,
                end_date = EndDate,
                type = Type,
                email = Email,
                delete_all = (DeleteAll ?? false) ? "1" : null
            });

            WriteObject(result);
        }
    }
}
