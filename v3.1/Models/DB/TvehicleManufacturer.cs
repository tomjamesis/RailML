using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TvehicleManufacturer
    {
        public TvehicleManufacturer()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short TvehicleManufacturerId { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
