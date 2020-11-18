using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TsignalSpeed
    {
        public TsignalSpeed()
        {
            Tsignal = new HashSet<Tsignal>();
        }

        public short TsignalSpeedId { get; set; }
        public long SpeedChangeRef { get; set; }
        public string Kind { get; set; }
        public string TrainRelation { get; set; }

        public virtual TelementWithReference SpeedChangeRefNavigation { get; set; }
        public virtual ICollection<Tsignal> Tsignal { get; set; }
    }
}
