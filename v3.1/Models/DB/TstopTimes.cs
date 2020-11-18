using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TstopTimes
    {
        public TstopTimes()
        {
            EstopDescription = new HashSet<EstopDescription>();
        }

        public long TstopTimesId { get; set; }
        public string MinimalTime { get; set; }
        public string OperationalReserve { get; set; }
        public string AdditionalReserve { get; set; }
        public string ShuntingTime { get; set; }
        public string ClearanceTime { get; set; }

        public virtual ICollection<EstopDescription> EstopDescription { get; set; }
    }
}
