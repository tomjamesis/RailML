using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtimetablePeriods
    {
        public EtimetablePeriods()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long EtimetablePeriodsId { get; set; }
        public short TimetablePeriod { get; set; }

        public virtual EtimetablePeriod TimetablePeriodNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
