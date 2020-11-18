using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EsectionTt
    {
        public EsectionTt()
        {
            EocpTt = new HashSet<EocpTt>();
        }

        public short EsectionTtid { get; set; }
        public short TrackRef { get; set; }
        public long RunTimes { get; set; }

        public virtual TrunTimes RunTimesNavigation { get; set; }
        public virtual TtrackRef TrackRefNavigation { get; set; }
        public virtual ICollection<EocpTt> EocpTt { get; set; }
    }
}
