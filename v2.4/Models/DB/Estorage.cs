using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Estorage
    {
        public Estorage()
        {
            Eengine = new HashSet<Eengine>();
        }

        public short EstorageId { get; set; }
        public short Efficiency { get; set; }

        public virtual TefficiencyCurve EfficiencyNavigation { get; set; }
        public virtual ICollection<Eengine> Eengine { get; set; }
    }
}
