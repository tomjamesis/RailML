using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TdecelerationCurve
    {
        public TdecelerationCurve()
        {
            TbasicBrakeOperation = new HashSet<TbasicBrakeOperation>();
        }

        public short TdecelerationCurveId { get; set; }

        public virtual ICollection<TbasicBrakeOperation> TbasicBrakeOperation { get; set; }
    }
}
