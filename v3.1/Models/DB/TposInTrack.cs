using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TposInTrack
    {
        public TposInTrack()
        {
            TtrainDetector = new HashSet<TtrainDetector>();
        }

        public byte TposInTrackId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TtrainDetector> TtrainDetector { get; set; }
    }
}
