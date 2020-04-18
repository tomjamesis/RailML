using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtimeSpan
    {
        public long TtimeSpanId { get; set; }
        public DateTime From { get; set; }
        public DateTime Until { get; set; }
    }
}
