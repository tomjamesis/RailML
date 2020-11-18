using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TplacesTt
    {
        public TplacesTt()
        {
            EpassengerFacilityTt = new HashSet<EpassengerFacilityTt>();
        }

        public long TplacesTtid { get; set; }
        public string Category { get; set; }
        public string TapTsiType9039Code { get; set; }
        public string Count { get; set; }
        public string Description { get; set; }
        public string Reservation { get; set; }

        public virtual ICollection<EpassengerFacilityTt> EpassengerFacilityTt { get; set; }
    }
}
