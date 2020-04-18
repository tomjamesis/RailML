using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tgangway
    {
        public Tgangway()
        {
            Epassenger = new HashSet<Epassenger>();
        }

        public long TgangwayId { get; set; }
        public bool FrontEnd { get; set; }
        public bool RearEnd { get; set; }
        public string Position { get; set; }
        public string DesignType { get; set; }
        public decimal FloorLevelValue { get; set; }
        public bool FloorLevelValueSpecified { get; set; }
        public decimal GangwayHeightValue { get; set; }
        public bool GangwayHeightValueSpecified { get; set; }
        public decimal GangwayWidthValue { get; set; }
        public bool GangwayWidthValueSpecified { get; set; }

        public virtual ICollection<Epassenger> Epassenger { get; set; }
    }
}
