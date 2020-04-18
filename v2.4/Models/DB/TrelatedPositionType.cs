using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TrelatedPositionType
    {
        public TrelatedPositionType()
        {
            TelectricalWagonCouplerType = new HashSet<TelectricalWagonCouplerType>();
        }

        public byte TrelatedPositionTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TelectricalWagonCouplerType> TelectricalWagonCouplerType { get; set; }
    }
}
