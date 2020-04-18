using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EexternalReference
    {
        public EexternalReference()
        {
            EconnectionTt = new HashSet<EconnectionTt>();
        }

        public long EexternalReferenceId { get; set; }
        public short TafTapTsiTrainId { get; set; }
        public long TrainNumber { get; set; }
        public long LineNumber { get; set; }
        public long Information { get; set; }

        public virtual EexternalReferenceInformation InformationNavigation { get; set; }
        public virtual EexternalReferenceLineNumber LineNumberNavigation { get; set; }
        public virtual EtapTsiTransportOperationalIdentifier TafTapTsiTrain { get; set; }
        public virtual EexternalReferenceTrainNumber TrainNumberNavigation { get; set; }
        public virtual ICollection<EconnectionTt> EconnectionTt { get; set; }
    }
}
