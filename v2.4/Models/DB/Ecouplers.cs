using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ecouplers
    {
        public Ecouplers()
        {
            Ewagon = new HashSet<Ewagon>();
        }

        public long EcouplersId { get; set; }
        public short MechanicalCoupler { get; set; }
        public short PneumaticCoupler { get; set; }
        public short ElectricalCoupler { get; set; }

        public virtual EelectricalCoupler ElectricalCouplerNavigation { get; set; }
        public virtual EmechanicalCoupler MechanicalCouplerNavigation { get; set; }
        public virtual EpneumaticCoupler PneumaticCouplerNavigation { get; set; }
        public virtual ICollection<Ewagon> Ewagon { get; set; }
    }
}
