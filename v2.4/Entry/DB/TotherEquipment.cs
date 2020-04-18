using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TotherEquipment
    {
        public TotherEquipment()
        {
            Emonitoring = new HashSet<Emonitoring>();
        }

        public short TotherEquipmentId { get; set; }
        public string OnBoardUnitId { get; set; }
        public string SoftwareVersion { get; set; }

        public virtual ICollection<Emonitoring> Emonitoring { get; set; }
    }
}
