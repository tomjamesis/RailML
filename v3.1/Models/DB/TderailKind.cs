using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TderailKind
    {
        public TderailKind()
        {
            Tderailer = new HashSet<Tderailer>();
        }

        public byte TderailKindId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Tderailer> Tderailer { get; set; }
    }
}
