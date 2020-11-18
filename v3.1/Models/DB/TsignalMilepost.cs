using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TsignalMilepost
    {
        public TsignalMilepost()
        {
            Tsignal = new HashSet<Tsignal>();
        }

        public short TsignalMilepostId { get; set; }
        public decimal ShownValueValue { get; set; }
        public bool ShownValueValueSpecified { get; set; }
        public string ShownRemark { get; set; }
        public string MileageChangeRef { get; set; }
        public string LineRef { get; set; }

        public virtual ICollection<Tsignal> Tsignal { get; set; }
    }
}
