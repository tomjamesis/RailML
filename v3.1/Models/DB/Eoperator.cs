using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eoperator
    {
        public Eoperator()
        {
            Eclassification = new HashSet<Eclassification>();
        }

        public short EoperatorId { get; set; }
        public long VehicleIdentification { get; set; }

        public virtual TvehicleIdentification VehicleIdentificationNavigation { get; set; }
        public virtual ICollection<Eclassification> Eclassification { get; set; }
    }
}
