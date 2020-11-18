using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Evehicles
    {
        public Evehicles()
        {
            Rollingstock = new HashSet<Rollingstock>();
        }

        public long EvehiclesId { get; set; }
        public short Vehicle { get; set; }

        public virtual Evehicle VehicleNavigation { get; set; }
        public virtual ICollection<Rollingstock> Rollingstock { get; set; }
    }
}
