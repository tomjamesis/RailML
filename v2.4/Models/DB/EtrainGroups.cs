using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrainGroups
    {
        public EtrainGroups()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long EtrainGroupsId { get; set; }
        public short TrainGroup { get; set; }

        public virtual EtrainGroup TrainGroupNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
