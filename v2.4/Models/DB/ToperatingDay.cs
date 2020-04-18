using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class ToperatingDay
    {
        public long ToperatingDayId { get; set; }
        public string Any { get; set; }
        public string OperatingCode { get; set; }
        public bool OnRequestValue { get; set; }
        public bool OnRequestValueSpecified { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }
    }
}
