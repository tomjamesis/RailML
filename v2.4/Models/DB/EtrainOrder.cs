using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrainOrder
    {
        public EtrainOrder()
        {
            Eformation = new HashSet<Eformation>();
        }

        public long EtrainOrderId { get; set; }
        public long VehicleRef { get; set; }

        public virtual TvehicleRef VehicleRefNavigation { get; set; }
        public virtual ICollection<Eformation> Eformation { get; set; }
    }
}
