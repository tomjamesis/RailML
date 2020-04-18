using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EstopActivities
    {
        public EstopActivities()
        {
            EstopDescription = new HashSet<EstopDescription>();
        }

        public long EstopActivitiesId { get; set; }
        public long StopActivity { get; set; }

        public virtual TstopActivity StopActivityNavigation { get; set; }
        public virtual ICollection<EstopDescription> EstopDescription { get; set; }
    }
}
