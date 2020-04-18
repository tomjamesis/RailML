using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tdoors
    {
        public long TdoorsId { get; set; }
        public string Number { get; set; }
        public decimal EntranceHeightValue { get; set; }
        public bool EntranceHeightValueSpecified { get; set; }
        public decimal EntranceLengthValue { get; set; }
        public bool EntranceLengthValueSpecified { get; set; }
        public decimal EntranceWidthValue { get; set; }
        public bool EntranceWidthValueSpecified { get; set; }
        public decimal FootStepHeightValue { get; set; }
        public bool FootStepHeightValueSpecified { get; set; }
        public decimal LockingSpeedValue { get; set; }
        public bool LockingSpeedValueSpecified { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
    }
}
