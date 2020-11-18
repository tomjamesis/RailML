using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tsignal
    {
        public Tsignal()
        {
            Esignals = new HashSet<Esignals>();
        }

        public short TsignalId { get; set; }
        public short Speed { get; set; }
        public short Etcs { get; set; }
        public short LevelCrossing { get; set; }
        public short TrainRadio { get; set; }
        public short Catenary { get; set; }
        public short Line { get; set; }
        public short Milepost { get; set; }
        public short Braking { get; set; }
        public long TrainProtectionElementGroupRef { get; set; }
        public long BaliseGroupRef { get; set; }
        public decimal SightValue { get; set; }
        public bool SightValueSpecified { get; set; }
        public string Type { get; set; }
        public string Function { get; set; }
        public string SigSystem { get; set; }
        public bool SwitchableValue { get; set; }
        public bool SwitchableValueSpecified { get; set; }
        public bool MaskableRouteValue { get; set; }
        public bool MaskableRouteValueSpecified { get; set; }
        public bool MaskableAtcvalue { get; set; }
        public bool MaskableAtcvalueSpecified { get; set; }
        public bool Virtual { get; set; }
        public string SignalBoxOcpRef { get; set; }
        public string StationOcpRef { get; set; }
        public decimal DistNearestDangerPointValue { get; set; }
        public bool DistNearestDangerPointValueSpecified { get; set; }
        public decimal TrackDistValue { get; set; }
        public bool TrackDistValueSpecified { get; set; }
        public decimal HeightValue { get; set; }
        public bool HeightValueSpecified { get; set; }
        public string OcpStationRef { get; set; }
        public string ControllerRef { get; set; }

        public virtual TelementWithReference BaliseGroupRefNavigation { get; set; }
        public virtual TsignalBraking BrakingNavigation { get; set; }
        public virtual TsignalCatenary CatenaryNavigation { get; set; }
        public virtual TsignalEtcs EtcsNavigation { get; set; }
        public virtual TsignalLevelCrossing LevelCrossingNavigation { get; set; }
        public virtual TsignalLine LineNavigation { get; set; }
        public virtual TsignalMilepost MilepostNavigation { get; set; }
        public virtual TsignalSpeed SpeedNavigation { get; set; }
        public virtual TelementWithReference TrainProtectionElementGroupRefNavigation { get; set; }
        public virtual TsignalTrainRadio TrainRadioNavigation { get; set; }
        public virtual ICollection<Esignals> Esignals { get; set; }
    }
}
