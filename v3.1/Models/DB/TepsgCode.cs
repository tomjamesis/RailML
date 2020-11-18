using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TepsgCode
    {
        public TepsgCode()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long TepsgCodeId { get; set; }
        public string Default { get; set; }
        public string ExtraHeight { get; set; }

        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
