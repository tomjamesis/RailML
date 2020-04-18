using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TstatisticAnalyses
    {
        public TstatisticAnalyses()
        {
            Estatistic = new HashSet<Estatistic>();
        }

        public long TstatisticAnalysesId { get; set; }
        public string Description { get; set; }
        public decimal PercentageValue { get; set; }
        public bool PercentageValueSpecified { get; set; }
        public string Value { get; set; }
        public string Figure { get; set; }

        public virtual ICollection<Estatistic> Estatistic { get; set; }
    }
}
