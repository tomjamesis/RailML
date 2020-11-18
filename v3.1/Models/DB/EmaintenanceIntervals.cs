using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EmaintenanceIntervals
    {
        public EmaintenanceIntervals()
        {
            Evehicle = new HashSet<Evehicle>();
        }

        public long EmaintenanceIntervalsId { get; set; }
        public short MaintenanceInterval { get; set; }

        public virtual TmaintenanceInterval MaintenanceIntervalNavigation { get; set; }
        public virtual ICollection<Evehicle> Evehicle { get; set; }
    }
}
