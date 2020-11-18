using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TsignalLine
    {
        public TsignalLine()
        {
            Tsignal = new HashSet<Tsignal>();
        }

        public short TsignalLineId { get; set; }
        public string Ref { get; set; }

        public virtual ICollection<Tsignal> Tsignal { get; set; }
    }
}
