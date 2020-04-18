using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EpulsePatternValueTable
    {
        public EpulsePatternValueTable()
        {
            EpulsePattern = new HashSet<EpulsePattern>();
        }

        public short EpulsePatternValueTableId { get; set; }

        public virtual ICollection<EpulsePattern> EpulsePattern { get; set; }
    }
}
