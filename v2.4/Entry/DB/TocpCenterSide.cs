using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TocpCenterSide
    {
        public TocpCenterSide()
        {
            TcrossSection = new HashSet<TcrossSection>();
        }

        public byte TocpCenterSideId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TcrossSection> TcrossSection { get; set; }
    }
}
