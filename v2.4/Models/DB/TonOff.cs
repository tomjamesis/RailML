using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TonOff
    {
        public TonOff()
        {
            TstopDescription = new HashSet<TstopDescription>();
        }

        public byte TonOffId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TstopDescription> TstopDescription { get; set; }
    }
}
