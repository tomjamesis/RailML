using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TcurvingLimitationType
    {
        public long TcurvingLimitationTypeId { get; set; }
        public decimal HorizontalCurveRadiusValue { get; set; }
        public bool HorizontalCurveRadiusValueSpecified { get; set; }
        public decimal VerticalCrestRadiusValue { get; set; }
        public bool VerticalCrestRadiusValueSpecified { get; set; }
        public decimal VerticalSagRadiusValue { get; set; }
        public bool VerticalSagRadiusValueSpecified { get; set; }
    }
}
