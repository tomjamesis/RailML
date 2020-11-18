using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TloadLimitMatrixType
    {
        public long TloadLimitMatrixTypeId { get; set; }
        public decimal ChassisSpeedValue { get; set; }
        public bool ChassisSpeedValueSpecified { get; set; }
    }
}
