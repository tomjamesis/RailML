using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EblockPartSequence
    {
        public EblockPartSequence()
        {
            Eblock = new HashSet<Eblock>();
        }

        public short EblockPartSequenceId { get; set; }
        public short BlockPartRef { get; set; }

        public virtual TblockPartRef BlockPartRefNavigation { get; set; }
        public virtual ICollection<Eblock> Eblock { get; set; }
    }
}
