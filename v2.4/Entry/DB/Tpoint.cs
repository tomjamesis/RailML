using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tpoint
    {
        public Tpoint()
        {
            EocpVis = new HashSet<EocpVis>();
            EtrackElementVis = new HashSet<EtrackElementVis>();
        }

        public long TpointId { get; set; }
        public long X { get; set; }
        public long Y { get; set; }

        public virtual ICollection<EocpVis> EocpVis { get; set; }
        public virtual ICollection<EtrackElementVis> EtrackElementVis { get; set; }
    }
}
