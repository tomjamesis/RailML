using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tpropulsion
    {
        public short TpropulsionId { get; set; }
        public decimal VoltageValue { get; set; }
        public bool VoltageValueSpecified { get; set; }
        public decimal FrequencyValue { get; set; }
        public bool FrequencyValueSpecified { get; set; }
        public decimal Power { get; set; }
        public string PowerType { get; set; }
        public string Transmission { get; set; }
        public string ControlType { get; set; }
        public decimal MaxTractEffortValue { get; set; }
        public bool MaxTractEffortValueSpecified { get; set; }
        public decimal RotationMassFactorValue { get; set; }
        public bool RotationMassFactorValueSpecified { get; set; }
        public decimal AdditionalRotationMassValue { get; set; }
        public bool AdditionalRotationMassValueSpecified { get; set; }
        public bool RackTractionValue { get; set; }
        public bool RackTractionValueSpecified { get; set; }
        public bool RemoteControlValue { get; set; }
        public bool RemoteControlValueSpecified { get; set; }
        public string NumberNotches { get; set; }
        public decimal WheelDiameterValue { get; set; }
        public bool WheelDiameterValueSpecified { get; set; }
        public decimal MaxBrakeEffortValue { get; set; }
        public bool MaxBrakeEffortValueSpecified { get; set; }
        public decimal MaxBrakePowerValue { get; set; }
        public bool MaxBrakePowerValueSpecified { get; set; }
        public decimal TotalTractEfficiencyValue { get; set; }
        public bool TotalTractEfficiencyValueSpecified { get; set; }
        public decimal TotalBrakeEfficiencyValue { get; set; }
        public bool TotalBrakeEfficiencyValueSpecified { get; set; }
        public decimal TractionOffUndervoltageThresholdValue { get; set; }
        public bool TractionOffUndervoltageThresholdValueSpecified { get; set; }
        public decimal ZeroSpeedCurrentLimitationValue { get; set; }
        public bool ZeroSpeedCurrentLimitationValueSpecified { get; set; }
        public decimal MaxRegenerativeVoltageValue { get; set; }
        public bool MaxRegenerativeVoltageValueSpecified { get; set; }
        public byte SpeedRangeValue { get; set; }
        public bool SpeedRangeValueSpecified { get; set; }
        public decimal ForwardSpeedValue { get; set; }
        public bool ForwardSpeedValueSpecified { get; set; }
        public decimal ReverseSpeedValue { get; set; }
        public bool ReverseSpeedValueSpecified { get; set; }
        public bool ActivationStandstillValue { get; set; }
        public bool ActivationStandstillValueSpecified { get; set; }

        public virtual TspeedRangeType SpeedRangeValueNavigation { get; set; }
    }
}
