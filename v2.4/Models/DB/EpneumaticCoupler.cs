using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EpneumaticCoupler
    {
        public EpneumaticCoupler()
        {
            Ecouplers = new HashSet<Ecouplers>();
        }

        public short EpneumaticCouplerId { get; set; }

        public virtual ICollection<Ecouplers> Ecouplers { get; set; }
    }
}
