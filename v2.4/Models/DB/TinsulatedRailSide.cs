using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TinsulatedRailSide
    {
        public TinsulatedRailSide()
        {
            TtrackCircuitBorder = new HashSet<TtrackCircuitBorder>();
        }

        public byte TinsulatedRailSideId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TtrackCircuitBorder> TtrackCircuitBorder { get; set; }
    }
}
