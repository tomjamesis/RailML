using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Epantograph
    {
        public Epantograph()
        {
            Eengine = new HashSet<Eengine>();
        }

        public short EpantographId { get; set; }
        public long DedicatedSupplySystem { get; set; }

        public virtual TelectrificationSystem DedicatedSupplySystemNavigation { get; set; }
        public virtual ICollection<Eengine> Eengine { get; set; }
    }
}
