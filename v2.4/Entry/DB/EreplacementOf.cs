using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EreplacementOf
    {
        public EreplacementOf()
        {
            EreplacedTrains = new HashSet<EreplacedTrains>();
        }

        public long EreplacementOfId { get; set; }
        public short OperatingPeriodRef { get; set; }
        public short TafTapTsiTrainId { get; set; }
        public long UniqueTrainKey { get; set; }

        public virtual ToperatingPeriodRef OperatingPeriodRefNavigation { get; set; }
        public virtual EtapTsiTransportOperationalIdentifier TafTapTsiTrain { get; set; }
        public virtual TuniqueTrainKey UniqueTrainKeyNavigation { get; set; }
        public virtual ICollection<EreplacedTrains> EreplacedTrains { get; set; }
    }
}
