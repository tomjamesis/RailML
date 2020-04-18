using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Eequipment
    {
        public Eequipment()
        {
            EequipmentUsage = new HashSet<EequipmentUsage>();
        }

        public short EequipmentId { get; set; }
        public long Etcs { get; set; }

        public virtual TetcsTt EtcsNavigation { get; set; }
        public virtual ICollection<EequipmentUsage> EequipmentUsage { get; set; }
    }
}
