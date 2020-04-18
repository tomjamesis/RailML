using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tsize
    {
        public Tsize()
        {
            EocpVis = new HashSet<EocpVis>();
        }

        public long TsizeId { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }

        public virtual ICollection<EocpVis> EocpVis { get; set; }
    }
}
