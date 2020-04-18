using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TmaxTrainCurrent
    {
        public TmaxTrainCurrent()
        {
            Telectrification = new HashSet<Telectrification>();
            TelectrificationChange = new HashSet<TelectrificationChange>();
        }

        public long TmaxTrainCurrentId { get; set; }
        public decimal MaxCurrentValue { get; set; }
        public bool MaxCurrentValueSpecified { get; set; }
        public byte TypeValue { get; set; }
        public bool TypeValueSpecified { get; set; }
        public byte ValidForValue { get; set; }
        public bool ValidForValueSpecified { get; set; }

        public virtual TmaxTrainCurrentType TypeValueNavigation { get; set; }
        public virtual TmaxTrainCurrentValidFor ValidForValueNavigation { get; set; }
        public virtual ICollection<Telectrification> Telectrification { get; set; }
        public virtual ICollection<TelectrificationChange> TelectrificationChange { get; set; }
    }
}
