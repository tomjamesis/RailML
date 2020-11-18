using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrackElements
    {
        public EtrackElements()
        {
            Etrack = new HashSet<Etrack>();
        }

        public long EtrackElementsId { get; set; }
        public long SpeedChanges { get; set; }
        public long GradientChanges { get; set; }
        public long RadiusChanges { get; set; }
        public long Tunnels { get; set; }
        public long Bridges { get; set; }
        public long LevelCrossings { get; set; }
        public long OwnerChanges { get; set; }
        public long OperationModeChanges { get; set; }
        public long TrainProtectionChanges { get; set; }
        public long ElectrificationChanges { get; set; }
        public long PowerTransmissionChanges { get; set; }
        public long AxleWeightChanges { get; set; }
        public long GaugeChanges { get; set; }
        public long ClearanceGaugeChanges { get; set; }
        public long GeoMappings { get; set; }
        public long TrackConditions { get; set; }
        public long PlatformEdges { get; set; }
        public long ServiceSections { get; set; }
        public string Any { get; set; }

        public virtual EaxleWeightChanges AxleWeightChangesNavigation { get; set; }
        public virtual Ebridges BridgesNavigation { get; set; }
        public virtual EclearanceGaugeChanges ClearanceGaugeChangesNavigation { get; set; }
        public virtual EelectrificationChanges ElectrificationChangesNavigation { get; set; }
        public virtual EgaugeChanges GaugeChangesNavigation { get; set; }
        public virtual EgeoMappings GeoMappingsNavigation { get; set; }
        public virtual EgradientChanges GradientChangesNavigation { get; set; }
        public virtual ElevelCrossings LevelCrossingsNavigation { get; set; }
        public virtual EoperationModeChanges OperationModeChangesNavigation { get; set; }
        public virtual EownerChanges OwnerChangesNavigation { get; set; }
        public virtual EplatformEdges PlatformEdgesNavigation { get; set; }
        public virtual EpowerTransmissionChanges PowerTransmissionChangesNavigation { get; set; }
        public virtual EradiusChanges RadiusChangesNavigation { get; set; }
        public virtual EserviceSections ServiceSectionsNavigation { get; set; }
        public virtual EspeedChanges SpeedChangesNavigation { get; set; }
        public virtual EtrackConditions TrackConditionsNavigation { get; set; }
        public virtual EtrainProtectionChanges TrainProtectionChangesNavigation { get; set; }
        public virtual Etunnels TunnelsNavigation { get; set; }
        public virtual ICollection<Etrack> Etrack { get; set; }
    }
}
