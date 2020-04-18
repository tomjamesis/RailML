using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ToperationalUndertaking
    {
        public ToperationalUndertaking()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short ToperationalUndertakingId { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
