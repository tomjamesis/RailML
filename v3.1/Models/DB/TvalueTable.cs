using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TvalueTable
    {
        public long TvalueTableId { get; set; }
        public long ColumnHeader { get; set; }
        public long ValueLine { get; set; }
        public string XvalueName { get; set; }
        public string XvalueUnit { get; set; }
        public string YvalueName { get; set; }
        public string YvalueUnit { get; set; }
        public string ZvalueName { get; set; }
        public string ZvalueUnit { get; set; }

        public virtual TvalueTableColumnHeader ColumnHeaderNavigation { get; set; }
        public virtual TvalueTableValueLine ValueLineNavigation { get; set; }
    }
}
