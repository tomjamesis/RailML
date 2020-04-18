using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EocpPropOther
    {
        public EocpPropOther()
        {
            Eocp = new HashSet<Eocp>();
        }

        public short EocpPropOtherId { get; set; }
        public long AdditionalName { get; set; }
        public long States { get; set; }

        public virtual TocpAdditionalName AdditionalNameNavigation { get; set; }
        public virtual Tstates StatesNavigation { get; set; }
        public virtual ICollection<Eocp> Eocp { get; set; }
    }
}
