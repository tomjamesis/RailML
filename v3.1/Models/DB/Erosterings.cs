using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Erosterings
    {
        public Erosterings()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long ErosteringsId { get; set; }
        public short Rostering { get; set; }

        public virtual Erostering RosteringNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
