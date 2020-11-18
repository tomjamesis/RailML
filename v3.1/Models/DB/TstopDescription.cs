using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TstopDescription
    {
        public long TstopDescriptionId { get; set; }
        public string Any { get; set; }
        public bool CommercialValue { get; set; }
        public bool CommercialValueSpecified { get; set; }
        public bool StopOnRequestValue { get; set; }
        public bool StopOnRequestValueSpecified { get; set; }
        public byte OnOffValue { get; set; }
        public bool OnOffValueSpecified { get; set; }
        public string Purpose { get; set; }
        public bool GuaranteedPassValue { get; set; }
        public bool GuaranteedPassValueSpecified { get; set; }
        public bool OperationalStopOrderedValue { get; set; }
        public bool OperationalStopOrderedValueSpecified { get; set; }
        public string OperatingPeriodRef { get; set; }
        public string StopPostRef { get; set; }

        public virtual TonOff OnOffValueNavigation { get; set; }
    }
}
