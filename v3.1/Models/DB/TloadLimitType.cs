using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TloadLimitType
    {
        public long TloadLimitTypeId { get; set; }
        public decimal MaxSpeed { get; set; }
    }
}
