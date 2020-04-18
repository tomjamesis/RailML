using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Ebalises
    {
        public Ebalises()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long EbalisesId { get; set; }
        public short Balise { get; set; }
        public short BaliseGroup { get; set; }

        public virtual TbaliseGroup BaliseGroupNavigation { get; set; }
        public virtual Tbalise BaliseNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
