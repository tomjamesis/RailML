using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Etrain
    {
        public Etrain()
        {
            Etrains = new HashSet<Etrains>();
        }

        public short EtrainId { get; set; }
        public short TrainPartSequence { get; set; }
        public short TafTapTsiTrainId { get; set; }
        public long Replacements { get; set; }

        public virtual EreplacedTrains ReplacementsNavigation { get; set; }
        public virtual EtapTsiTransportOperationalIdentifier TafTapTsiTrain { get; set; }
        public virtual EtrainPartSequence TrainPartSequenceNavigation { get; set; }
        public virtual ICollection<Etrains> Etrains { get; set; }
    }
}
