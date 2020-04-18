using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TbasicBrakeType
    {
        public TbasicBrakeType()
        {
            Eformation = new HashSet<Eformation>();
        }

        public long TbasicBrakeTypeId { get; set; }
        public long AuxiliaryBrakes { get; set; }
        public string BrakeType { get; set; }
        public byte AirBrakeApplicationPositionValue { get; set; }
        public bool AirBrakeApplicationPositionValueSpecified { get; set; }
        public decimal RegularBrakeMassValue { get; set; }
        public bool RegularBrakeMassValueSpecified { get; set; }
        public decimal EmergencyBrakeMassValue { get; set; }
        public bool EmergencyBrakeMassValueSpecified { get; set; }
        public decimal MaxDecelerationValue { get; set; }
        public bool MaxDecelerationValueSpecified { get; set; }
        public decimal MeanDecelerationValue { get; set; }
        public bool MeanDecelerationValueSpecified { get; set; }

        public virtual TairBrakeApplicationPosition AirBrakeApplicationPositionValueNavigation { get; set; }
        public virtual TbasicBrakeTypeAuxiliaryBrakes AuxiliaryBrakesNavigation { get; set; }
        public virtual ICollection<Eformation> Eformation { get; set; }
    }
}
