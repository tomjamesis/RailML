using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TocpAdditionalName
    {
        public TocpAdditionalName()
        {
            EocpPropOther = new HashSet<EocpPropOther>();
        }

        public long TocpAdditionalNameId { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string Lang { get; set; }

        public virtual ICollection<EocpPropOther> EocpPropOther { get; set; }
    }
}
