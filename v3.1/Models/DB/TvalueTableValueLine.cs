using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TvalueTableValueLine
    {
        public TvalueTableValueLine()
        {
            TvalueTable = new HashSet<TvalueTable>();
        }

        public long TvalueTableValueLineId { get; set; }
        public long Values { get; set; }
        public decimal Xvalue { get; set; }

        public virtual TvalueTableValueLineValues ValuesNavigation { get; set; }
        public virtual ICollection<TvalueTable> TvalueTable { get; set; }
    }
}
