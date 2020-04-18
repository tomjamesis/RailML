using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TspeedInfo
    {
        public TspeedInfo()
        {
            Espeeds = new HashSet<Espeeds>();
        }

        public long TspeedInfoId { get; set; }
        public string TrainCategory { get; set; }
        public string EtcsTrainCategory { get; set; }
        public string ProfileRef { get; set; }
        public string Status { get; set; }
        public string Vmax { get; set; }

        public virtual ICollection<Espeeds> Espeeds { get; set; }
    }
}
