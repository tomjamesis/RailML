using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TocpPropOperational
    {
        public long TocpPropOperationalId { get; set; }
        public string OperationalType { get; set; }
        public string TrafficType { get; set; }
        public bool OrderChangeable { get; set; }
        public bool EnsuresTrainSequence { get; set; }
    }
}
