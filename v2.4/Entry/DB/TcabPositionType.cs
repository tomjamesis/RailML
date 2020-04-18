using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TcabPositionType
    {
        public TcabPositionType()
        {
            TdriversCabType = new HashSet<TdriversCabType>();
        }

        public byte TcabPositionTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TdriversCabType> TdriversCabType { get; set; }
    }
}
