using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TsignalBraking
    {
        public TsignalBraking()
        {
            Tsignal = new HashSet<Tsignal>();
        }

        public short TsignalBrakingId { get; set; }
        public string TrackConditionRef { get; set; }

        public virtual ICollection<Tsignal> Tsignal { get; set; }
    }
}
