using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TinterlockingTypes
    {
        public TinterlockingTypes()
        {
            TocpPropEquipmentSummary = new HashSet<TocpPropEquipmentSummary>();
        }

        public byte TinterlockingTypesId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TocpPropEquipmentSummary> TocpPropEquipmentSummary { get; set; }
    }
}
