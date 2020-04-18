using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ToperatingPeriod
    {
        public short ToperatingPeriodId { get; set; }
        public string TimetablePeriodRef { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }
        public string BitMask { get; set; }
    }
}
