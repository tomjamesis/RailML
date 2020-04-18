using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tvehicle
    {
        public short TvehicleId { get; set; }
        public string VehicleFamilyRef { get; set; }
        public string VehicleCategory { get; set; }
        public string AxleSequence { get; set; }
        public string NumberDrivenAxles { get; set; }
        public string NumberNonDrivenAxles { get; set; }
        public decimal TrackGaugeValue { get; set; }
        public bool TrackGaugeValueSpecified { get; set; }
        public decimal TrackGaugeAlternativeValue { get; set; }
        public bool TrackGaugeAlternativeValueSpecified { get; set; }
        public bool AdjustableWheelSetValue { get; set; }
        public bool AdjustableWheelSetValueSpecified { get; set; }
        public decimal LengthValue { get; set; }
        public bool LengthValueSpecified { get; set; }
        public decimal SpeedValue { get; set; }
        public bool SpeedValueSpecified { get; set; }
        public decimal TowingSpeedValue { get; set; }
        public bool TowingSpeedValueSpecified { get; set; }
        public decimal BruttoWeightValue { get; set; }
        public bool BruttoWeightValueSpecified { get; set; }
        public decimal NettoWeightValue { get; set; }
        public bool NettoWeightValueSpecified { get; set; }
        public decimal TareWeightValue { get; set; }
        public bool TareWeightValueSpecified { get; set; }
        public decimal BruttoAdhesionWeightValue { get; set; }
        public bool BruttoAdhesionWeightValueSpecified { get; set; }
        public decimal TareAdhesionWeightValue { get; set; }
        public bool TareAdhesionWeightValueSpecified { get; set; }
        public decimal NettoAdhesionWeightValue { get; set; }
        public bool NettoAdhesionWeightValueSpecified { get; set; }
        public decimal AxleLoadValue { get; set; }
        public bool AxleLoadValueSpecified { get; set; }
        public decimal ResistanceFactorValue { get; set; }
        public bool ResistanceFactorValueSpecified { get; set; }
        public bool OnTrainHeadValue { get; set; }
        public bool OnTrainHeadValueSpecified { get; set; }
        public bool OnTrainTailOnlyValue { get; set; }
        public bool OnTrainTailOnlyValueSpecified { get; set; }
    }
}
