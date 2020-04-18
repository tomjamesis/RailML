using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtrackElementVis
    {
        public EtrackElementVis()
        {
            EtrackVis = new HashSet<EtrackVis>();
        }

        public short EtrackElementVisId { get; set; }
        public long Position { get; set; }

        public virtual Tpoint PositionNavigation { get; set; }
        public virtual ICollection<EtrackVis> EtrackVis { get; set; }
    }
}
