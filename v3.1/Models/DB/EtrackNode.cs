using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrackNode
    {
        public short EtrackNodeId { get; set; }
        public string Connection { get; set; }
        public short BufferStop { get; set; }
        public short OpenEnd { get; set; }
        public long MacroscopicNode { get; set; }

        public virtual TbufferStop BufferStopNavigation { get; set; }
        public virtual TconnectionData ConnectionNavigation { get; set; }
        public virtual TmacroscopicNode MacroscopicNodeNavigation { get; set; }
        public virtual TopenEnd OpenEndNavigation { get; set; }
    }
}
