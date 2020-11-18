using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ebridge
    {
        public Ebridge()
        {
            Ebridges = new HashSet<Ebridges>();
        }

        public short EbridgeId { get; set; }
        public long CrossedElements { get; set; }

        public virtual EcrossedElements CrossedElementsNavigation { get; set; }
        public virtual ICollection<Ebridges> Ebridges { get; set; }
    }
}
