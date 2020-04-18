using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EplatformEdges
    {
        public EplatformEdges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EplatformEdgesId { get; set; }
        public short PlatformEdge { get; set; }

        public virtual TplatformEdge PlatformEdgeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
