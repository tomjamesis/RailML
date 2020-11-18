using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TocpTttype
    {
        public TocpTttype()
        {
            TocpTt = new HashSet<TocpTt>();
        }

        public byte TocpTttypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TocpTt> TocpTt { get; set; }
    }
}
