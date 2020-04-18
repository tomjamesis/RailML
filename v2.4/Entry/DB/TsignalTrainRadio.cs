using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TsignalTrainRadio
    {
        public TsignalTrainRadio()
        {
            Tsignal = new HashSet<Tsignal>();
        }

        public short TsignalTrainRadioId { get; set; }
        public string TrackConditionRef { get; set; }

        public virtual ICollection<Tsignal> Tsignal { get; set; }
    }
}
