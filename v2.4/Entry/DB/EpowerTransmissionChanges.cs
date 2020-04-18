using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EpowerTransmissionChanges
    {
        public EpowerTransmissionChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EpowerTransmissionChangesId { get; set; }
        public short PowerTransmissionChange { get; set; }

        public virtual TpowerTransmissionChange PowerTransmissionChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
