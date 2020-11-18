using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eformations
    {
        public Eformations()
        {
            Rollingstock = new HashSet<Rollingstock>();
        }

        public long EformationsId { get; set; }
        public short Formation { get; set; }

        public virtual Eformation FormationNavigation { get; set; }
        public virtual ICollection<Rollingstock> Rollingstock { get; set; }
    }
}
