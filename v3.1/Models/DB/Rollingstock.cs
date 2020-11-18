using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Rollingstock
    {
        public Rollingstock()
        {
            Railml = new HashSet<Railml>();
        }

        public short RollingstockId { get; set; }
        public long Vehicles { get; set; }
        public long Formations { get; set; }

        public virtual Eformations FormationsNavigation { get; set; }
        public virtual Evehicles VehiclesNavigation { get; set; }
        public virtual ICollection<Railml> Railml { get; set; }
    }
}
