using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainEngine
    {
        public TtrainEngine()
        {
            Eformation = new HashSet<Eformation>();
        }

        public long TtrainEngineId { get; set; }
        public decimal TrainMeanAccelerationValue { get; set; }
        public bool TrainMeanAccelerationValueSpecified { get; set; }
        public decimal TrainMaxAccelerationValue { get; set; }
        public bool TrainMaxAccelerationValueSpecified { get; set; }
        public string TrainMinTimeHoldSpeed { get; set; }

        public virtual ICollection<Eformation> Eformation { get; set; }
    }
}
