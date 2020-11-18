using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtechnicalStopActivity
    {
        public TtechnicalStopActivity()
        {
            Eformation = new HashSet<Eformation>();
        }

        public long TtechnicalStopActivityId { get; set; }
        public string MinimumTime { get; set; }
        public string Purpose { get; set; }

        public virtual ICollection<Eformation> Eformation { get; set; }
    }
}
