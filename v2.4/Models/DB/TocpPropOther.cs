using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TocpPropOther
    {
        public long TocpPropOtherId { get; set; }
        public bool Frontier { get; set; }
        public bool ChargeFrontier { get; set; }
        public string Status { get; set; }
    }
}
