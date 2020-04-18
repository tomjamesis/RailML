using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TaxleWeightChange
    {
        public TaxleWeightChange()
        {
            EaxleWeightChanges = new HashSet<EaxleWeightChanges>();
        }

        public short TaxleWeightChangeId { get; set; }
        public decimal Value { get; set; }
        public decimal MeterloadValue { get; set; }
        public bool MeterloadValueSpecified { get; set; }

        public virtual ICollection<EaxleWeightChanges> EaxleWeightChanges { get; set; }
    }
}
