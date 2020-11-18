using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eborder
    {
        public Eborder()
        {
            EtrackTopology = new HashSet<EtrackTopology>();
        }

        public long EborderId { get; set; }
        public short Border { get; set; }

        public virtual Tborder BorderNavigation { get; set; }
        public virtual ICollection<EtrackTopology> EtrackTopology { get; set; }
    }
}
