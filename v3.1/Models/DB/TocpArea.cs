using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TocpArea
    {
        public TocpArea()
        {
            Eocp = new HashSet<Eocp>();
        }

        public long TocpAreaId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Eocp> Eocp { get; set; }
    }
}
