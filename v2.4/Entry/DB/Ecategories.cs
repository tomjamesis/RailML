using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Ecategories
    {
        public Ecategories()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long EcategoriesId { get; set; }
        public short Category { get; set; }

        public virtual Ecategory CategoryNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
