using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TbasicBrakeOperation
    {
        public TbasicBrakeOperation()
        {
            Eformation = new HashSet<Eformation>();
            EvehicleBrakes = new HashSet<EvehicleBrakes>();
        }

        public long TbasicBrakeOperationId { get; set; }
        public short DecelerationTable { get; set; }
        public string BrakeSupervision { get; set; }
        public string DecelerationDelay { get; set; }
        public decimal ReleaseSpeedValue { get; set; }
        public bool ReleaseSpeedValueSpecified { get; set; }
        public decimal MeanDecelerationValue { get; set; }
        public bool MeanDecelerationValueSpecified { get; set; }

        public virtual TdecelerationCurve DecelerationTableNavigation { get; set; }
        public virtual ICollection<Eformation> Eformation { get; set; }
        public virtual ICollection<EvehicleBrakes> EvehicleBrakes { get; set; }
    }
}
