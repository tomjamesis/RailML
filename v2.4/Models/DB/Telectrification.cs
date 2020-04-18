using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Telectrification
    {
        public Telectrification()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long TelectrificationId { get; set; }
        public long MaxTrainCurrent { get; set; }
        public string Type { get; set; }
        public decimal Voltage { get; set; }
        public decimal Frequency { get; set; }

        public virtual TmaxTrainCurrent MaxTrainCurrentNavigation { get; set; }
        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
