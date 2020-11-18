using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainAlignment
    {
        public TtrainAlignment()
        {
            TocpTt = new HashSet<TocpTt>();
        }

        public byte TtrainAlignmentId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TocpTt> TocpTt { get; set; }
    }
}
