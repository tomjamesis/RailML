using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TstateWithLength
    {
        public TstateWithLength()
        {
            TstatesWithLength = new HashSet<TstatesWithLength>();
        }

        public short TstateWithLengthId { get; set; }
        public long From { get; set; }
        public long To { get; set; }

        public virtual Tlocation FromNavigation { get; set; }
        public virtual ICollection<TstatesWithLength> TstatesWithLength { get; set; }
    }
}
