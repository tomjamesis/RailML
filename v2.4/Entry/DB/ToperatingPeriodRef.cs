using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ToperatingPeriodRef
    {
        public ToperatingPeriodRef()
        {
            EreplacementOf = new HashSet<EreplacementOf>();
        }

        public short ToperatingPeriodRefId { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }

        public virtual ICollection<EreplacementOf> EreplacementOf { get; set; }
    }
}
