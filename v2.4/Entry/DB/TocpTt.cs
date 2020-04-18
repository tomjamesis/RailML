using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TocpTt
    {
        public long TocpTtid { get; set; }
        public string Sequence { get; set; }
        public string OcpRef { get; set; }
        public string TrackRef { get; set; }
        public string TrackInfo { get; set; }
        public byte OcpTypeValue { get; set; }
        public bool OcpTypeValueSpecified { get; set; }
        public string Remarks { get; set; }
        public bool TrainReverseValue { get; set; }
        public bool TrainReverseValueSpecified { get; set; }
        public byte AlignmentValue { get; set; }
        public bool AlignmentValueSpecified { get; set; }
        public decimal OffsetValue { get; set; }
        public bool OffsetValueSpecified { get; set; }
        public string ShuntingTime { get; set; }

        public virtual TtrainAlignment AlignmentValueNavigation { get; set; }
        public virtual TocpTttype OcpTypeValueNavigation { get; set; }
    }
}
