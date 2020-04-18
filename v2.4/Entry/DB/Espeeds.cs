using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Espeeds
    {
        public Espeeds()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long EspeedsId { get; set; }
        public long Speed { get; set; }

        public virtual TspeedInfo SpeedNavigation { get; set; }
        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
