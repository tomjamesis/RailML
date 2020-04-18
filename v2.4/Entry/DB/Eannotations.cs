using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Eannotations
    {
        public Eannotations()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long EannotationsId { get; set; }
        public short Annotation { get; set; }

        public virtual Eannotation AnnotationNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
