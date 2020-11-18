using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tpantograph
    {
        public long TpantographId { get; set; }
        public string OrderNumber { get; set; }
        public string DesignType { get; set; }
        public string PositionOnSection { get; set; }
        public string FittedSection { get; set; }
        public string ControlType { get; set; }
        public decimal HeadWidthValue { get; set; }
        public bool HeadWidthValueSpecified { get; set; }
        public decimal MaxCurrentDrivingValue { get; set; }
        public bool MaxCurrentDrivingValueSpecified { get; set; }
        public decimal MaxCurrentStandstillValue { get; set; }
        public bool MaxCurrentStandstillValueSpecified { get; set; }
    }
}
