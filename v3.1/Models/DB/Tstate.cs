using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tstate
    {
        public Tstate()
        {
            Tstates = new HashSet<Tstates>();
        }

        public long TstateId { get; set; }
        public string Any { get; set; }
        public bool Disabled { get; set; }
        public string Status { get; set; }
        public string OperatingPeriodRef { get; set; }
        public DateTime StartTimeValue { get; set; }
        public bool StartTimeValueSpecified { get; set; }
        public DateTime EndTimeValue { get; set; }
        public bool EndTimeValueSpecified { get; set; }
        public string EndDayOffset { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<Tstates> Tstates { get; set; }
    }
}
