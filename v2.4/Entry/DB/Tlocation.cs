using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tlocation
    {
        public Tlocation()
        {
            TstateWithLength = new HashSet<TstateWithLength>();
        }

        public long TlocationId { get; set; }
        public long GeoCoord { get; set; }
        public string OcpRef { get; set; }
        public decimal Pos { get; set; }
        public decimal AbsPosValue { get; set; }
        public bool AbsPosValueSpecified { get; set; }
        public decimal AbsPosOffsetValue { get; set; }
        public bool AbsPosOffsetValueSpecified { get; set; }

        public virtual TgeoCoord GeoCoordNavigation { get; set; }
        public virtual ICollection<TstateWithLength> TstateWithLength { get; set; }
    }
}
