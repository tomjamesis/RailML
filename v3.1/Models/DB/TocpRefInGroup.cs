using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TocpRefInGroup
    {
        public TocpRefInGroup()
        {
            Tpath = new HashSet<Tpath>();
        }

        public short TocpRefInGroupId { get; set; }

        public virtual ICollection<Tpath> Tpath { get; set; }
    }
}
