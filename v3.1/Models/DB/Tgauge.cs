using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tgauge
    {
        public Tgauge()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long TgaugeId { get; set; }
        public decimal Value { get; set; }

        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
