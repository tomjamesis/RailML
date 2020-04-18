using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EauxiliarySupply
    {
        public EauxiliarySupply()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short EauxiliarySupplyId { get; set; }
        public long DedicatedSupplySystem { get; set; }

        public virtual TauxiliarySupplySystem DedicatedSupplySystemNavigation { get; set; }
        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
