using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TelectrificationSystem
    {
        public TelectrificationSystem()
        {
            Epantograph = new HashSet<Epantograph>();
            Ewagon = new HashSet<Ewagon>();
        }

        public long TelectrificationSystemId { get; set; }
        public decimal VoltageValue { get; set; }
        public bool VoltageValueSpecified { get; set; }
        public decimal FrequencyValue { get; set; }
        public bool FrequencyValueSpecified { get; set; }

        public virtual ICollection<Epantograph> Epantograph { get; set; }
        public virtual ICollection<Ewagon> Ewagon { get; set; }
    }
}
