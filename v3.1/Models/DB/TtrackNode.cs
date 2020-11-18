using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrackNode
    {
        public long GeoCoord { get; set; }
        public string TtrackNodeId { get; set; }
        public decimal Pos { get; set; }
        public decimal AbsPosValue { get; set; }
        public bool AbsPosValueSpecified { get; set; }
        public decimal AbsPosOffsetValue { get; set; }
        public bool AbsPosOffsetValueSpecified { get; set; }

        public virtual TgeoCoord GeoCoordNavigation { get; set; }
    }
}
