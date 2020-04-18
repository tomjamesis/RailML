using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TstopActivity
    {
        public TstopActivity()
        {
            EstopActivities = new HashSet<EstopActivities>();
        }

        public long TstopActivityId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<EstopActivities> EstopActivities { get; set; }
    }
}
