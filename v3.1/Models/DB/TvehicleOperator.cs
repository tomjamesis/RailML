using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TvehicleOperator
    {
        public TvehicleOperator()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short TvehicleOperatorId { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
