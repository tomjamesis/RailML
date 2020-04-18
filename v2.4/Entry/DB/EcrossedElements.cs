using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EcrossedElements
    {
        public EcrossedElements()
        {
            Ebridge = new HashSet<Ebridge>();
            ElevelCrossing = new HashSet<ElevelCrossing>();
            Etunnel = new HashSet<Etunnel>();
        }

        public long EcrossedElementsId { get; set; }
        public short CrossedElement { get; set; }

        public virtual TcrossedElement CrossedElementNavigation { get; set; }
        public virtual ICollection<Ebridge> Ebridge { get; set; }
        public virtual ICollection<ElevelCrossing> ElevelCrossing { get; set; }
        public virtual ICollection<Etunnel> Etunnel { get; set; }
    }
}
