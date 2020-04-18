using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EvehicleBrakes
    {
        public EvehicleBrakes()
        {
            Evehicle = new HashSet<Evehicle>();
        }

        public long EvehicleBrakesId { get; set; }
        public short VehicleBrake { get; set; }
        public long VehicleBrakeOperation { get; set; }
        public short MechanicalBrakeEffort { get; set; }
        public long EddyCurrentBrake { get; set; }

        public virtual TeddyCurrentBrake EddyCurrentBrakeNavigation { get; set; }
        public virtual TeffortCurve MechanicalBrakeEffortNavigation { get; set; }
        public virtual EvehicleBrake VehicleBrakeNavigation { get; set; }
        public virtual TbasicBrakeOperation VehicleBrakeOperationNavigation { get; set; }
        public virtual ICollection<Evehicle> Evehicle { get; set; }
    }
}
