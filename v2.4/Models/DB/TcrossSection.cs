using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TcrossSection
    {
        public TcrossSection()
        {
            EcrossSections = new HashSet<EcrossSections>();
        }

        public short TcrossSectionId { get; set; }
        public string Type { get; set; }
        public string OcpRef { get; set; }
        public byte OcpTrackIdvalue { get; set; }
        public bool OcpTrackIdvalueSpecified { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }
        public byte OcpCenterSideValue { get; set; }
        public bool OcpCenterSideValueSpecified { get; set; }

        public virtual TlaxDirection DirValueNavigation { get; set; }
        public virtual TocpCenterSide OcpCenterSideValueNavigation { get; set; }
        public virtual ICollection<EcrossSections> EcrossSections { get; set; }
    }
}
