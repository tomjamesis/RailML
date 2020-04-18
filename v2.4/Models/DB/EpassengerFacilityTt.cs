using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EpassengerFacilityTt
    {
        public EpassengerFacilityTt()
        {
            EformationTt = new HashSet<EformationTt>();
        }

        public long EpassengerFacilityTtid { get; set; }
        public string Any { get; set; }
        public long Places { get; set; }
        public long Service { get; set; }

        public virtual TplacesTt PlacesNavigation { get; set; }
        public virtual Tservice ServiceNavigation { get; set; }
        public virtual ICollection<EformationTt> EformationTt { get; set; }
    }
}
