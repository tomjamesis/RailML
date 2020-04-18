using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TmacroscopicNode
    {
        public TmacroscopicNode()
        {
            EtrackNode = new HashSet<EtrackNode>();
        }

        public long TmacroscopicNodeId { get; set; }
        public string OcpRef { get; set; }
        public string FlowDirection { get; set; }

        public virtual ICollection<EtrackNode> EtrackNode { get; set; }
    }
}
