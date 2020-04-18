using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Egoods
    {
        public Egoods()
        {
            Ewagon = new HashSet<Ewagon>();
        }

        public short EgoodsId { get; set; }
        public long Service { get; set; }

        public virtual Tservice ServiceNavigation { get; set; }
        public virtual ICollection<Ewagon> Ewagon { get; set; }
    }
}
