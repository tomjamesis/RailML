using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EreservationInfo
    {
        public EreservationInfo()
        {
            EformationTt = new HashSet<EformationTt>();
        }

        public long EreservationInfoId { get; set; }
        public long Booking { get; set; }

        public virtual Tbooking BookingNavigation { get; set; }
        public virtual ICollection<EformationTt> EformationTt { get; set; }
    }
}
