using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TvalueTableColumnHeader
    {
        public TvalueTableColumnHeader()
        {
            TvalueTable = new HashSet<TvalueTable>();
        }

        public long TvalueTableColumnHeaderId { get; set; }
        public decimal Zvalue { get; set; }

        public virtual ICollection<TvalueTable> TvalueTable { get; set; }
    }
}
