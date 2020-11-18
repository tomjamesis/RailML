using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TvehicleIdentification
    {
        public TvehicleIdentification()
        {
            Eoperator = new HashSet<Eoperator>();
        }

        public long TvehicleIdentificationId { get; set; }
        public string UicIdentNumber { get; set; }
        public string CountryCode { get; set; }
        public string VehicleKeeperMarking { get; set; }

        public virtual ICollection<Eoperator> Eoperator { get; set; }
    }
}
