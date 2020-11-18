using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eengine
    {
        public Eengine()
        {
            Evehicle = new HashSet<Evehicle>();
        }

        public short EengineId { get; set; }
        public short Propulsion { get; set; }
        public short Pantograph { get; set; }
        public short EnergyStorage { get; set; }
        public short Monitoring { get; set; }

        public virtual Estorage EnergyStorageNavigation { get; set; }
        public virtual Emonitoring MonitoringNavigation { get; set; }
        public virtual Epantograph PantographNavigation { get; set; }
        public virtual Epropulsion PropulsionNavigation { get; set; }
        public virtual ICollection<Evehicle> Evehicle { get; set; }
    }
}
