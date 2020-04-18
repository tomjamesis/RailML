using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TpowerTransmissionChange
    {
        public TpowerTransmissionChange()
        {
            EpowerTransmissionChanges = new HashSet<EpowerTransmissionChanges>();
        }

        public short TpowerTransmissionChangeId { get; set; }
        public string Type { get; set; }
        public string Style { get; set; }

        public virtual ICollection<EpowerTransmissionChanges> EpowerTransmissionChanges { get; set; }
    }
}
