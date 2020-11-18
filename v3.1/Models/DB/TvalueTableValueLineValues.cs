using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TvalueTableValueLineValues
    {
        public TvalueTableValueLineValues()
        {
            TvalueTableValueLine = new HashSet<TvalueTableValueLine>();
        }

        public long TvalueTableValueLineValuesId { get; set; }
        public decimal Yvalue { get; set; }

        public virtual ICollection<TvalueTableValueLine> TvalueTableValueLine { get; set; }
    }
}
