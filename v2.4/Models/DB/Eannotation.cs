using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eannotation
    {
        public Eannotation()
        {
            Eannotations = new HashSet<Eannotations>();
        }

        public short EannotationId { get; set; }
        public long Text { get; set; }

        public virtual TannotationText TextNavigation { get; set; }
        public virtual ICollection<Eannotations> Eannotations { get; set; }
    }
}
