using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ToperatingDayDeviance
    {
        public ToperatingDayDeviance()
        {
            EoperatingDay = new HashSet<EoperatingDay>();
        }

        public long ToperatingDayDevianceId { get; set; }
        public string OperatingCode { get; set; }
        public bool OnRequestValue { get; set; }
        public bool OnRequestValueSpecified { get; set; }
        public string HolidayOffset { get; set; }
        public string Ranking { get; set; }

        public virtual ICollection<EoperatingDay> EoperatingDay { get; set; }
    }
}
