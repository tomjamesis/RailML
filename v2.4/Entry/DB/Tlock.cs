using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tlock
    {
        public Tlock()
        {
            Elocks = new HashSet<Elocks>();
        }

        public short TlockId { get; set; }

        public virtual ICollection<Elocks> Elocks { get; set; }
    }
}
