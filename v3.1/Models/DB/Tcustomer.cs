using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tcustomer
    {
        public Tcustomer()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short TcustomerId { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
