using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Timetable
    {
        public Timetable()
        {
            Railml = new HashSet<Railml>();
        }

        public short TimetableId { get; set; }
        public long TimetablePeriods { get; set; }
        public long OperatingPeriods { get; set; }
        public long Categories { get; set; }
        public long Annotations { get; set; }
        public long TrainParts { get; set; }
        public long Trains { get; set; }
        public long TrainGroups { get; set; }
        public long Rosterings { get; set; }

        public virtual Eannotations AnnotationsNavigation { get; set; }
        public virtual Ecategories CategoriesNavigation { get; set; }
        public virtual EoperatingPeriods OperatingPeriodsNavigation { get; set; }
        public virtual Erosterings RosteringsNavigation { get; set; }
        public virtual EtimetablePeriods TimetablePeriodsNavigation { get; set; }
        public virtual EtrainGroups TrainGroupsNavigation { get; set; }
        public virtual EtrainParts TrainPartsNavigation { get; set; }
        public virtual Etrains TrainsNavigation { get; set; }
        public virtual ICollection<Railml> Railml { get; set; }
    }
}
