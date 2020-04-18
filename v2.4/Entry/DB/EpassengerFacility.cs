using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EpassengerFacility
    {
        public long EpassengerFacilityId { get; set; }
        public long Places { get; set; }
        public long Service { get; set; }

        public virtual Tplaces PlacesNavigation { get; set; }
        public virtual Tservice ServiceNavigation { get; set; }
    }
}
