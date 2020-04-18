using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TairBrakeApplicationPosition
    {
        public TairBrakeApplicationPosition()
        {
            TbasicBrakeType = new HashSet<TbasicBrakeType>();
            Tbraking = new HashSet<Tbraking>();
        }

        public byte TairBrakeApplicationPositionId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TbasicBrakeType> TbasicBrakeType { get; set; }
        public virtual ICollection<Tbraking> Tbraking { get; set; }
    }
}
