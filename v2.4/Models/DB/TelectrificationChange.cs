using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TelectrificationChange
    {
        public TelectrificationChange()
        {
            EelectrificationChanges = new HashSet<EelectrificationChanges>();
        }

        public short TelectrificationChangeId { get; set; }
        public long MaxTrainCurrent { get; set; }
        public string Type { get; set; }
        public decimal Voltage { get; set; }
        public decimal Frequency { get; set; }
        public decimal VmaxValue { get; set; }
        public bool VmaxValueSpecified { get; set; }
        public bool IsolatedSection { get; set; }

        public virtual TmaxTrainCurrent MaxTrainCurrentNavigation { get; set; }
        public virtual ICollection<EelectrificationChanges> EelectrificationChanges { get; set; }
    }
}
