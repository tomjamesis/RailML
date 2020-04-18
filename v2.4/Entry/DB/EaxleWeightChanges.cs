using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EaxleWeightChanges
    {
        public EaxleWeightChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EaxleWeightChangesId { get; set; }
        public short AxleWeightChange { get; set; }

        public virtual TaxleWeightChange AxleWeightChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
