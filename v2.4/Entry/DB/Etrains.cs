using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Etrains
    {
        public Etrains()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long EtrainsId { get; set; }
        public short Train { get; set; }

        public virtual Etrain TrainNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
