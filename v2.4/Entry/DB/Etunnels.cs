using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Etunnels
    {
        public Etunnels()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EtunnelsId { get; set; }
        public short Tunnel { get; set; }

        public virtual Etunnel TunnelNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
