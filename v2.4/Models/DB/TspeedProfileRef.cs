using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TspeedProfileRef
    {
        public TspeedProfileRef()
        {
            EtrainPartSequence = new HashSet<EtrainPartSequence>();
        }

        public short TspeedProfileRefId { get; set; }

        public virtual ICollection<EtrainPartSequence> EtrainPartSequence { get; set; }
    }
}
