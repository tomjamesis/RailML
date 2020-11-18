using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EreplacedTrains
    {
        public EreplacedTrains()
        {
            Etrain = new HashSet<Etrain>();
        }

        public long EreplacedTrainsId { get; set; }
        public long ReplacementOf { get; set; }

        public virtual EreplacementOf ReplacementOfNavigation { get; set; }
        public virtual ICollection<Etrain> Etrain { get; set; }
    }
}
