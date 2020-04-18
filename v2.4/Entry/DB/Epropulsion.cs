using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Epropulsion
    {
        public Epropulsion()
        {
            Eengine = new HashSet<Eengine>();
        }

        public short EpropulsionId { get; set; }
        public short Transformer { get; set; }
        public short FourQuadrantChopper { get; set; }
        public long Link { get; set; }
        public short TractionInverter { get; set; }
        public short TractionMotor { get; set; }
        public long Diesel { get; set; }
        public short Gear { get; set; }
        public short AuxiliarySupply { get; set; }
        public short TractiveEffort { get; set; }
        public short BrakeEffort { get; set; }
        public short TractiveCurrent { get; set; }
        public short BrakeCurrent { get; set; }
        public short TractiveCurrentLimitation { get; set; }
        public short BrakeCurrentLimitation { get; set; }
        public short TractiveVehicleEfficiency { get; set; }
        public short BrakeVehicleEfficiency { get; set; }
        public long RackTraction { get; set; }

        public virtual EauxiliarySupply AuxiliarySupplyNavigation { get; set; }
        public virtual TdieselEngine DieselNavigation { get; set; }
        public virtual EfourQuadrantChopper FourQuadrantChopperNavigation { get; set; }
        public virtual Egear GearNavigation { get; set; }
        public virtual Tlink LinkNavigation { get; set; }
        public virtual TrackTractionType RackTractionNavigation { get; set; }
        public virtual EtractionInverter TractionInverterNavigation { get; set; }
        public virtual EtractionMotor TractionMotorNavigation { get; set; }
        public virtual TcurrentLimitation TractiveCurrentLimitationNavigation { get; set; }
        public virtual TcurrentCurve TractiveCurrentNavigation { get; set; }
        public virtual TeffortCurve TractiveEffortNavigation { get; set; }
        public virtual TefficiencyCurve TractiveVehicleEfficiencyNavigation { get; set; }
        public virtual Etransformer TransformerNavigation { get; set; }
        public virtual ICollection<Eengine> Eengine { get; set; }
    }
}
