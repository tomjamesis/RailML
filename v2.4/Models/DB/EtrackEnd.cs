using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrackEnd
    {
        public EtrackEnd()
        {
            EtrackTopology = new HashSet<EtrackTopology>();
        }

        public short EtrackEndId { get; set; }
        public decimal AbsPosInValue { get; set; }
        public bool AbsPosInValueSpecified { get; set; }

        public virtual ICollection<EtrackTopology> EtrackTopology { get; set; }
    }
}
