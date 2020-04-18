using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TadditionalOcpName
    {
        public TadditionalOcpName()
        {
            TocpWithIdandName = new HashSet<TocpWithIdandName>();
        }

        public long TadditionalOcpNameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }
        public string Type { get; set; }

        public virtual ICollection<TocpWithIdandName> TocpWithIdandName { get; set; }
    }
}
