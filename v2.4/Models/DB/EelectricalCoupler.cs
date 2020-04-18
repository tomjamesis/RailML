using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EelectricalCoupler
    {
        public EelectricalCoupler()
        {
            Ecouplers = new HashSet<Ecouplers>();
        }

        public short EelectricalCouplerId { get; set; }

        public virtual ICollection<Ecouplers> Ecouplers { get; set; }
    }
}
