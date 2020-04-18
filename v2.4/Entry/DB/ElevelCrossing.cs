using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ElevelCrossing
    {
        public ElevelCrossing()
        {
            ElevelCrossings = new HashSet<ElevelCrossings>();
        }

        public short ElevelCrossingId { get; set; }
        public long CrossedElements { get; set; }

        public virtual EcrossedElements CrossedElementsNavigation { get; set; }
        public virtual ICollection<ElevelCrossings> ElevelCrossings { get; set; }
    }
}
