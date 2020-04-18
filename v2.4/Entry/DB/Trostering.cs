using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Trostering
    {
        public short TrosteringId { get; set; }
        public string VehicleRef { get; set; }
        public string FormationRef { get; set; }
        public string Depot { get; set; }
        public string DefaultPreProcessingTime { get; set; }
        public string DefaultPostProcessingTime { get; set; }
        public string Scope { get; set; }
    }
}
