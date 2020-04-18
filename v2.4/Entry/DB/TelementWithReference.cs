using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TelementWithReference
    {
        public TelementWithReference()
        {
            Eformation = new HashSet<Eformation>();
            EinfraAttrGroupRefs = new HashSet<EinfraAttrGroupRefs>();
            EorganizationalUnitBinding = new HashSet<EorganizationalUnitBinding>();
            TsignalBaliseGroupRefNavigation = new HashSet<Tsignal>();
            TsignalSpeed = new HashSet<TsignalSpeed>();
            TsignalTrainProtectionElementGroupRefNavigation = new HashSet<Tsignal>();
            TstopPost = new HashSet<TstopPost>();
            TtrainProtectionElementGroup = new HashSet<TtrainProtectionElementGroup>();
        }

        public long TelementWithReferenceId { get; set; }
        public string Ref { get; set; }

        public virtual ICollection<Eformation> Eformation { get; set; }
        public virtual ICollection<EinfraAttrGroupRefs> EinfraAttrGroupRefs { get; set; }
        public virtual ICollection<EorganizationalUnitBinding> EorganizationalUnitBinding { get; set; }
        public virtual ICollection<Tsignal> TsignalBaliseGroupRefNavigation { get; set; }
        public virtual ICollection<TsignalSpeed> TsignalSpeed { get; set; }
        public virtual ICollection<Tsignal> TsignalTrainProtectionElementGroupRefNavigation { get; set; }
        public virtual ICollection<TstopPost> TstopPost { get; set; }
        public virtual ICollection<TtrainProtectionElementGroup> TtrainProtectionElementGroup { get; set; }
    }
}
