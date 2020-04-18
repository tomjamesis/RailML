using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TplatformEdge
    {
        public TplatformEdge()
        {
            EplatformEdges = new HashSet<EplatformEdges>();
        }

        public short TplatformEdgeId { get; set; }
        public string ParentPlatformEdgeRef { get; set; }

        public virtual ICollection<EplatformEdges> EplatformEdges { get; set; }
    }
}
