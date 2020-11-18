using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tborder
    {
        public Tborder()
        {
            Eborder = new HashSet<Eborder>();
        }

        public short TborderId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Eborder> Eborder { get; set; }
    }
}
