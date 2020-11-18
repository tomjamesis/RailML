using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrackBegin
    {
        public EtrackBegin()
        {
            EtrackTopology = new HashSet<EtrackTopology>();
        }

        public short EtrackBeginId { get; set; }
        public byte AbsDirValue { get; set; }
        public bool AbsDirValueSpecified { get; set; }

        public virtual TmileageDirection AbsDirValueNavigation { get; set; }
        public virtual ICollection<EtrackTopology> EtrackTopology { get; set; }
    }
}
