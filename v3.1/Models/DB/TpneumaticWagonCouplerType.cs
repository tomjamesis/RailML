using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TpneumaticWagonCouplerType
    {
        public long TpneumaticWagonCouplerTypeId { get; set; }
        public byte PositionOnCarEnd { get; set; }
        public string CouplerFunction { get; set; }
        public bool IntegratedOnMechanicalCouplerValue { get; set; }
        public bool IntegratedOnMechanicalCouplerValueSpecified { get; set; }

        public virtual TendPositionType PositionOnCarEndNavigation { get; set; }
    }
}
