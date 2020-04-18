using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EmechanicalCoupler
    {
        public EmechanicalCoupler()
        {
            Ecouplers = new HashSet<Ecouplers>();
        }

        public short EmechanicalCouplerId { get; set; }

        public virtual ICollection<Ecouplers> Ecouplers { get; set; }
    }
}
