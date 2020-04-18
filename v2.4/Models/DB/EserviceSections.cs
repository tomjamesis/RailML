using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EserviceSections
    {
        public EserviceSections()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EserviceSectionsId { get; set; }
        public short ServiceSection { get; set; }

        public virtual TserviceSection ServiceSectionNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
