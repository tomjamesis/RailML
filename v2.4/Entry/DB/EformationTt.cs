using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EformationTt
    {
        public EformationTt()
        {
            EtrainPart = new HashSet<EtrainPart>();
        }

        public short EformationTtid { get; set; }
        public long EquipmentUsage { get; set; }
        public long PassengerUsage { get; set; }
        public long ReservationInfo { get; set; }

        public virtual EequipmentUsage EquipmentUsageNavigation { get; set; }
        public virtual EpassengerFacilityTt PassengerUsageNavigation { get; set; }
        public virtual EreservationInfo ReservationInfoNavigation { get; set; }
        public virtual ICollection<EtrainPart> EtrainPart { get; set; }
    }
}
