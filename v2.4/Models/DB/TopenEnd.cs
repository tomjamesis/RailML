using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TopenEnd
    {
        public TopenEnd()
        {
            EtrackNode = new HashSet<EtrackNode>();
        }

        public short TopenEndId { get; set; }

        public virtual ICollection<EtrackNode> EtrackNode { get; set; }
    }
}
