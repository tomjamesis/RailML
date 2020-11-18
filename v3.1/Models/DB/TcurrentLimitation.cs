using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TcurrentLimitation
    {
        public TcurrentLimitation()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short TcurrentLimitationId { get; set; }

        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
