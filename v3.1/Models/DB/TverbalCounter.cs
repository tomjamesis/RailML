using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TverbalCounter
    {
        public TverbalCounter()
        {
            Tpassenger = new HashSet<Tpassenger>();
        }

        public byte TverbalCounterId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Tpassenger> Tpassenger { get; set; }
    }
}
