using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TbaseServiceSection
    {
        public short TbaseServiceSectionId { get; set; }
        public decimal HeightValue { get; set; }
        public bool HeightValueSpecified { get; set; }
        public byte SideValue { get; set; }
        public bool SideValueSpecified { get; set; }
        public string OcpRef { get; set; }

        public virtual Tside SideValueNavigation { get; set; }
    }
}
