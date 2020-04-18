using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TelectricalWagonCouplerType
    {
        public long TelectricalWagonCouplerTypeId { get; set; }
        public byte PositionOnCarEnd { get; set; }
        public string DesignType { get; set; }
        public byte PositionOnMechanicalCouplerValue { get; set; }
        public bool PositionOnMechanicalCouplerValueSpecified { get; set; }
        public string NumberContacts { get; set; }

        public virtual TendPositionType PositionOnCarEndNavigation { get; set; }
        public virtual TrelatedPositionType PositionOnMechanicalCouplerValueNavigation { get; set; }
    }
}
