using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EcurvingLimitation
    {
        public EcurvingLimitation()
        {
            Evehicle = new HashSet<Evehicle>();
        }

        public short EcurvingLimitationId { get; set; }

        public virtual ICollection<Evehicle> Evehicle { get; set; }
    }
}
