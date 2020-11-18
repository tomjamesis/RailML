using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TconnectionData
    {
        public TconnectionData()
        {
            EtrackNode = new HashSet<EtrackNode>();
        }

        public string TconnectionDataId { get; set; }
        public string Ref { get; set; }

        public virtual ICollection<EtrackNode> EtrackNode { get; set; }
    }
}
