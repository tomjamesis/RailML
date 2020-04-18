using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TocpWithIdandName
    {
        public long AdditionalName { get; set; }
        public string Any { get; set; }
        public string TocpWithIdandNameId { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }

        public virtual TadditionalOcpName AdditionalNameNavigation { get; set; }
    }
}
