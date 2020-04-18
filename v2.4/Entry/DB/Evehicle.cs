using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Evehicle
    {
        public Evehicle()
        {
            Evehicles = new HashSet<Evehicles>();
        }

        public short EvehicleId { get; set; }
        public long Classification { get; set; }
        public short Engine { get; set; }
        public short Wagon { get; set; }
        public long VehicleBrakes { get; set; }
        public short LoadLimitMatrix { get; set; }
        public short CurvingLimitation { get; set; }
        public long MaintenanceIntervals { get; set; }

        public virtual Eclassification ClassificationNavigation { get; set; }
        public virtual EcurvingLimitation CurvingLimitationNavigation { get; set; }
        public virtual Eengine EngineNavigation { get; set; }
        public virtual EloadLimitMatrix LoadLimitMatrixNavigation { get; set; }
        public virtual EmaintenanceIntervals MaintenanceIntervalsNavigation { get; set; }
        public virtual EvehicleBrakes VehicleBrakesNavigation { get; set; }
        public virtual Ewagon WagonNavigation { get; set; }
        public virtual ICollection<Evehicles> Evehicles { get; set; }
    }
}
