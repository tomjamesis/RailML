using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TstatesWithLength
    {
        public TstatesWithLength()
        {
            TplacedElementWithLength = new HashSet<TplacedElementWithLength>();
            Ttrack = new HashSet<Ttrack>();
        }

        public long TstatesWithLengthId { get; set; }
        public short State { get; set; }

        public virtual TstateWithLength StateNavigation { get; set; }
        public virtual ICollection<TplacedElementWithLength> TplacedElementWithLength { get; set; }
        public virtual ICollection<Ttrack> Ttrack { get; set; }
    }
}
