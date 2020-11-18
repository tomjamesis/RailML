using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ecirculations
    {
        public Ecirculations()
        {
            Erostering = new HashSet<Erostering>();
        }

        public long EcirculationsId { get; set; }
        public long Circulation { get; set; }

        public virtual Tcirculation CirculationNavigation { get; set; }
        public virtual ICollection<Erostering> Erostering { get; set; }
    }
}
