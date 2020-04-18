using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Twagon
    {
        public long TwagonId { get; set; }
        public decimal RotationMassFactorValue { get; set; }
        public bool RotationMassFactorValueSpecified { get; set; }
        public decimal AdditionalRotationMassValue { get; set; }
        public bool AdditionalRotationMassValueSpecified { get; set; }
        public string KinematicEnvelope { get; set; }
        public decimal AuxiliaryPowerConsumptionValue { get; set; }
        public bool AuxiliaryPowerConsumptionValueSpecified { get; set; }
        public string HeadShape { get; set; }
        public decimal HeadSurfaceValue { get; set; }
        public bool HeadSurfaceValueSpecified { get; set; }
        public string BearingType { get; set; }
    }
}
