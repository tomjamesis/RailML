using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainPartSequence
    {
        public long TtrainPartSequenceId { get; set; }
        public string Any { get; set; }
        public string Sequence { get; set; }
        public string PathStatus { get; set; }
        public string CategoryRef { get; set; }
    }
}
