using System;
using System.Collections.Generic;

namespace Models.DB
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
