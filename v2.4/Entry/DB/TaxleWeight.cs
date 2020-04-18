using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TaxleWeight
    {
        public TaxleWeight()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long TaxleWeightId { get; set; }
        public decimal Value { get; set; }
        public decimal MeterloadValue { get; set; }
        public bool MeterloadValueSpecified { get; set; }

        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
