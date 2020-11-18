using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tconcessionaire
    {
        public Tconcessionaire()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short TconcessionaireId { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
