using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EmileageChanges
    {
        public EmileageChanges()
        {
            EtrackTopology = new HashSet<EtrackTopology>();
        }

        public long EmileageChangesId { get; set; }
        public short MileageChange { get; set; }

        public virtual TmileageChange MileageChangeNavigation { get; set; }
        public virtual ICollection<EtrackTopology> EtrackTopology { get; set; }
    }
}
