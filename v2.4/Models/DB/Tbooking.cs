using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tbooking
    {
        public Tbooking()
        {
            EreservationInfo = new HashSet<EreservationInfo>();
        }

        public long TbookingId { get; set; }
        public string BookingNumber { get; set; }
        public string PosInFormation { get; set; }
        public string VehicleRef { get; set; }

        public virtual ICollection<EreservationInfo> EreservationInfo { get; set; }
    }
}
