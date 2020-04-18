using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TmechanicalWagonCouplerType
    {
        public long TmechanicalWagonCouplerTypeId { get; set; }
        public string DesignType { get; set; }
        public byte PositionOnCarEnd { get; set; }
        public decimal CouplingHeightValue { get; set; }
        public bool CouplingHeightValueSpecified { get; set; }
        public decimal PullingForceValue { get; set; }
        public bool PullingForceValueSpecified { get; set; }
        public decimal PushingForceValue { get; set; }
        public bool PushingForceValueSpecified { get; set; }

        public virtual TendPositionType PositionOnCarEndNavigation { get; set; }
    }
}
