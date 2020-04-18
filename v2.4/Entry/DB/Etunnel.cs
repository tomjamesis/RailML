using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Etunnel
    {
        public Etunnel()
        {
            Etunnels = new HashSet<Etunnels>();
        }

        public short EtunnelId { get; set; }
        public long CrossedElements { get; set; }

        public virtual EcrossedElements CrossedElementsNavigation { get; set; }
        public virtual ICollection<Etunnels> Etunnels { get; set; }
    }
}
