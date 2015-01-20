using System.Management.Automation;

using SendGrid.PowerShell.Common;

namespace SendGrid.PowerShell.Profile
{
    [Cmdlet(VerbsCommon.Set, "SendGridProfile")]
    public class SetSendGridProfile : CmdletBase
    {
        [Parameter(Position = 0, Mandatory = false)]
        public string FirstName { get; set; }

        [Parameter(Position = 1, Mandatory = false)]
        public string LastName { get; set; }

        [Parameter(Position = 2, Mandatory = false)]
        public string Address { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public string City { get; set; }

        [Parameter(Position = 4, Mandatory = false)]
        public string State { get; set; }

        [Parameter(Position = 5, Mandatory = false)]
        public string Country { get; set; }

        [Parameter(Position = 6, Mandatory = false)]
        public string Zip { get; set; }

        [Parameter(Position = 7, Mandatory = false)]
        public string Phone { get; set; }

        [Parameter(Position = 8, Mandatory = false)]
        public string Website { get; set; }

        protected override void ProcessRecord()
        {
            var result = Post<GenericResult>("profile", "set", new
            {
                first_name = FirstName,
                last_name = LastName,
                address = Address,
                city = City,
                state = State,
                country = Country,
                zip = Zip,
                phone = Phone,
                website = Website
            });

            WriteObject(result);
        }
    }
}
