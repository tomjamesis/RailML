using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TrackTractionType
    {
        public TrackTractionType()
        {
            Epropulsion = new HashSet<Epropulsion>();
            Ewagon = new HashSet<Ewagon>();
        }

        public long TrackTractionTypeId { get; set; }
        public string Number { get; set; }
        public string RackSystem { get; set; }
        public bool ResilentCogWheel { get; set; }

        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
        public virtual ICollection<Ewagon> Ewagon { get; set; }
    }
}
