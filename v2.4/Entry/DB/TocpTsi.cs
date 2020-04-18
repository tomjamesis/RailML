using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TocpTsi
    {
        public TocpTsi()
        {
            Eocp = new HashSet<Eocp>();
        }

        public long TocpTsiId { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string Check { get; set; }

        public virtual ICollection<Eocp> Eocp { get; set; }
    }
}
