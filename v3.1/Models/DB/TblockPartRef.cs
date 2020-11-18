using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TblockPartRef
    {
        public TblockPartRef()
        {
            EblockPartSequence = new HashSet<EblockPartSequence>();
        }

        public short TblockPartRefId { get; set; }

        public virtual ICollection<EblockPartSequence> EblockPartSequence { get; set; }
    }
}
