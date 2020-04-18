using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Econnections
    {
        public Econnections()
        {
            EtrackTopology = new HashSet<EtrackTopology>();
        }

        public long EconnectionsId { get; set; }
        public short Switch { get; set; }
        public short Crossing { get; set; }

        public virtual Ecrossing CrossingNavigation { get; set; }
        public virtual Eswitch SwitchNavigation { get; set; }
        public virtual ICollection<EtrackTopology> EtrackTopology { get; set; }
    }
}
