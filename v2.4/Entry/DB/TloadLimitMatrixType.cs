using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TloadLimitMatrixType
    {
        public long TloadLimitMatrixTypeId { get; set; }
        public decimal ChassisSpeedValue { get; set; }
        public bool ChassisSpeedValueSpecified { get; set; }
    }
}
