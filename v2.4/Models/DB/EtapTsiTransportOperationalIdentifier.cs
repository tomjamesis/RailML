using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtapTsiTransportOperationalIdentifier
    {
        public EtapTsiTransportOperationalIdentifier()
        {
            EexternalReference = new HashSet<EexternalReference>();
            EreplacementOf = new HashSet<EreplacementOf>();
            Etrain = new HashSet<Etrain>();
        }

        public short EtapTsiTransportOperationalIdentifierId { get; set; }

        public virtual ICollection<EexternalReference> EexternalReference { get; set; }
        public virtual ICollection<EreplacementOf> EreplacementOf { get; set; }
        public virtual ICollection<Etrain> Etrain { get; set; }
    }
}
