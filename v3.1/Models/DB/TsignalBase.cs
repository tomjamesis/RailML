using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TsignalBase
    {
        public long TsignalBaseId { get; set; }
        public bool SwitchableValue { get; set; }
        public bool SwitchableValueSpecified { get; set; }
    }
}
