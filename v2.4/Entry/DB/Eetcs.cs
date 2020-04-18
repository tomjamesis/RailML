using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Eetcs
    {
        public Eetcs()
        {
            Emonitoring = new HashSet<Emonitoring>();
        }

        public short Eetcsid { get; set; }
        public short SpecificTransmissionModule { get; set; }

        public virtual TspecificTransmissionModule SpecificTransmissionModuleNavigation { get; set; }
        public virtual ICollection<Emonitoring> Emonitoring { get; set; }
    }
}
