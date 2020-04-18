using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TrunTimes
    {
        public TrunTimes()
        {
            EsectionTt = new HashSet<EsectionTt>();
        }

        public long TrunTimesId { get; set; }
        public string MinimalTime { get; set; }
        public string OperationalReserve { get; set; }
        public string AdditionalReserve { get; set; }

        public virtual ICollection<EsectionTt> EsectionTt { get; set; }
    }
}
