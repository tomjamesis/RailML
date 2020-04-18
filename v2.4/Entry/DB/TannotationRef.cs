using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TannotationRef
    {
        public TannotationRef()
        {
            EconnectionTt = new HashSet<EconnectionTt>();
            EstopDescription = new HashSet<EstopDescription>();
            EtrainPart = new HashSet<EtrainPart>();
        }

        public short TannotationRefId { get; set; }
        public string OperatingPeriodRef { get; set; }

        public virtual ICollection<EconnectionTt> EconnectionTt { get; set; }
        public virtual ICollection<EstopDescription> EstopDescription { get; set; }
        public virtual ICollection<EtrainPart> EtrainPart { get; set; }
    }
}
