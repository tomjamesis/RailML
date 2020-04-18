using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtopologyReference
    {
        public TtopologyReference()
        {
            EtrainPartSequence = new HashSet<EtrainPartSequence>();
        }

        public long TtopologyReferenceId { get; set; }
        public string Register { get; set; }
        public string Entry { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }

        public virtual ICollection<EtrainPartSequence> EtrainPartSequence { get; set; }
    }
}
