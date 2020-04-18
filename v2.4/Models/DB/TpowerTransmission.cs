using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TpowerTransmission
    {
        public TpowerTransmission()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long TpowerTransmissionId { get; set; }
        public string Type { get; set; }
        public string Style { get; set; }

        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
