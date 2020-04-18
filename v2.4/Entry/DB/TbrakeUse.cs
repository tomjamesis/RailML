using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TbrakeUse
    {
        public TbrakeUse()
        {
            TbasicBrakeTypeAuxiliaryBrakes = new HashSet<TbasicBrakeTypeAuxiliaryBrakes>();
        }

        public byte TbrakeUseId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TbasicBrakeTypeAuxiliaryBrakes> TbasicBrakeTypeAuxiliaryBrakes { get; set; }
    }
}
