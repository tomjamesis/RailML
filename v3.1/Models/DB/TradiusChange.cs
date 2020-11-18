using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TradiusChange
    {
        public TradiusChange()
        {
            EradiusChanges = new HashSet<EradiusChanges>();
        }

        public short TradiusChangeId { get; set; }
        public decimal Radius { get; set; }
        public decimal SuperelevationValue { get; set; }
        public bool SuperelevationValueSpecified { get; set; }
        public string GeometryElementDescription { get; set; }

        public virtual ICollection<EradiusChanges> EradiusChanges { get; set; }
    }
}
