using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrainPartRef
    {
        public TtrainPartRef()
        {
            EtrainPartSequence = new HashSet<EtrainPartSequence>();
        }

        public short TtrainPartRefId { get; set; }
        public string Position { get; set; }

        public virtual ICollection<EtrainPartSequence> EtrainPartSequence { get; set; }
    }
}
