using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eblock
    {
        public Eblock()
        {
            Eblocks = new HashSet<Eblocks>();
        }

        public short EblockId { get; set; }
        public short BlockPartSequence { get; set; }

        public virtual EblockPartSequence BlockPartSequenceNavigation { get; set; }
        public virtual ICollection<Eblocks> Eblocks { get; set; }
    }
}
