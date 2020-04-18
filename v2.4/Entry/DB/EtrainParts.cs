using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtrainParts
    {
        public EtrainParts()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long EtrainPartsId { get; set; }
        public short TrainPart { get; set; }

        public virtual EtrainPart TrainPartNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
