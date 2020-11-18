using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TspecialService
    {
        public TspecialService()
        {
            EoperatingPeriod = new HashSet<EoperatingPeriod>();
            EoperatingPeriodRef = new HashSet<EoperatingPeriodRef>();
        }

        public long TspecialServiceId { get; set; }
        public short Type { get; set; }
        public DateTime SingleDateValue { get; set; }
        public bool SingleDateValueSpecified { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }
        public DateTime StartTimeValue { get; set; }
        public bool StartTimeValueSpecified { get; set; }
        public DateTime EndTimeValue { get; set; }
        public bool EndTimeValueSpecified { get; set; }

        public virtual Type TypeNavigation { get; set; }
        public virtual ICollection<EoperatingPeriod> EoperatingPeriod { get; set; }
        public virtual ICollection<EoperatingPeriodRef> EoperatingPeriodRef { get; set; }
    }
}
