using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TclearanceGaugeType
    {
        public TclearanceGaugeType()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
            Ewagon = new HashSet<Ewagon>();
            TclearanceGaugeChange = new HashSet<TclearanceGaugeChange>();
        }

        public long TclearanceGaugeTypeId { get; set; }
        public string Code { get; set; }

        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
        public virtual ICollection<Ewagon> Ewagon { get; set; }
        public virtual ICollection<TclearanceGaugeChange> TclearanceGaugeChange { get; set; }
    }
}
