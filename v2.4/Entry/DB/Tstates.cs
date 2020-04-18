using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tstates
    {
        public Tstates()
        {
            EocpPropOther = new HashSet<EocpPropOther>();
            Infrastructure = new HashSet<Infrastructure>();
            Tcontroller = new HashSet<Tcontroller>();
            Tline = new HashSet<Tline>();
            TlocallyControlledArea = new HashSet<TlocallyControlledArea>();
            TplacedElement = new HashSet<TplacedElement>();
        }

        public long TstatesId { get; set; }
        public long State { get; set; }

        public virtual Tstate StateNavigation { get; set; }
        public virtual ICollection<EocpPropOther> EocpPropOther { get; set; }
        public virtual ICollection<Infrastructure> Infrastructure { get; set; }
        public virtual ICollection<Tcontroller> Tcontroller { get; set; }
        public virtual ICollection<Tline> Tline { get; set; }
        public virtual ICollection<TlocallyControlledArea> TlocallyControlledArea { get; set; }
        public virtual ICollection<TplacedElement> TplacedElement { get; set; }
    }
}
