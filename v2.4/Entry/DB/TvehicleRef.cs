using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TvehicleRef
    {
        public TvehicleRef()
        {
            EtrainOrder = new HashSet<EtrainOrder>();
        }

        public long TvehicleRefId { get; set; }
        public string OrderNumber { get; set; }
        public string VehicleRef { get; set; }
        public string VehicleCount { get; set; }
        public bool FrontGangwayValue { get; set; }
        public bool FrontGangwayValueSpecified { get; set; }
        public bool RearGangwayValue { get; set; }
        public bool RearGangwayValueSpecified { get; set; }

        public virtual ICollection<EtrainOrder> EtrainOrder { get; set; }
    }
}
