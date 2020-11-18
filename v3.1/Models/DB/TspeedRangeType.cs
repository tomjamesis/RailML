using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TspeedRangeType
    {
        public TspeedRangeType()
        {
            Tpropulsion = new HashSet<Tpropulsion>();
        }

        public byte TspeedRangeTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Tpropulsion> Tpropulsion { get; set; }
    }
}
