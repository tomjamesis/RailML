using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TgaugeChange
    {
        public TgaugeChange()
        {
            EgaugeChanges = new HashSet<EgaugeChanges>();
        }

        public short TgaugeChangeId { get; set; }
        public decimal Value { get; set; }

        public virtual ICollection<EgaugeChanges> EgaugeChanges { get; set; }
    }
}
