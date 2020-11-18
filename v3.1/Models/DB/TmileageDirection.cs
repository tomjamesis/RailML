using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TmileageDirection
    {
        public TmileageDirection()
        {
            EtrackBegin = new HashSet<EtrackBegin>();
            TmileageChange = new HashSet<TmileageChange>();
        }

        public byte TmileageDirectionId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<EtrackBegin> EtrackBegin { get; set; }
        public virtual ICollection<TmileageChange> TmileageChange { get; set; }
    }
}
