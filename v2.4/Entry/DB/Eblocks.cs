using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Eblocks
    {
        public Eblocks()
        {
            Erostering = new HashSet<Erostering>();
        }

        public long EblocksId { get; set; }
        public short Block { get; set; }

        public virtual Eblock BlockNavigation { get; set; }
        public virtual ICollection<Erostering> Erostering { get; set; }
    }
}
