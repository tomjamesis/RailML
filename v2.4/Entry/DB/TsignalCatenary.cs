using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TsignalCatenary
    {
        public TsignalCatenary()
        {
            Tsignal = new HashSet<Tsignal>();
        }

        public short TsignalCatenaryId { get; set; }
        public string TrackConditionRef { get; set; }

        public virtual ICollection<Tsignal> Tsignal { get; set; }
    }
}
