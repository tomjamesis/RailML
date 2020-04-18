using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TrailwayUndertaking
    {
        public TrailwayUndertaking()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short TrailwayUndertakingId { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
