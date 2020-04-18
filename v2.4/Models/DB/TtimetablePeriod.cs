using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtimetablePeriod
    {
        public short TtimetablePeriodId { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }
        public DateTime StartTimeValue { get; set; }
        public bool StartTimeValueSpecified { get; set; }
        public DateTime EndTimeValue { get; set; }
        public bool EndTimeValueSpecified { get; set; }
    }
}
