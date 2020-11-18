using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TsignalLevelCrossing
    {
        public TsignalLevelCrossing()
        {
            Tsignal = new HashSet<Tsignal>();
        }

        public short TsignalLevelCrossingId { get; set; }
        public string Type { get; set; }
        public string Ref { get; set; }

        public virtual ICollection<Tsignal> Tsignal { get; set; }
    }
}
