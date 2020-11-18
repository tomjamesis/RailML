using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TendPositionType
    {
        public TendPositionType()
        {
            TelectricalWagonCouplerType = new HashSet<TelectricalWagonCouplerType>();
            TmechanicalWagonCouplerType = new HashSet<TmechanicalWagonCouplerType>();
            TpneumaticWagonCouplerType = new HashSet<TpneumaticWagonCouplerType>();
        }

        public byte TendPositionTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TelectricalWagonCouplerType> TelectricalWagonCouplerType { get; set; }
        public virtual ICollection<TmechanicalWagonCouplerType> TmechanicalWagonCouplerType { get; set; }
        public virtual ICollection<TpneumaticWagonCouplerType> TpneumaticWagonCouplerType { get; set; }
    }
}
