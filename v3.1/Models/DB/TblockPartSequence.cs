using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TblockPartSequence
    {
        public long TblockPartSequenceId { get; set; }
        public string Any { get; set; }
        public string Sequence { get; set; }
        public string DayOffset { get; set; }
        public string PreProcessingTime { get; set; }
        public string PostProcessingTime { get; set; }
        public string BasicBlockRef { get; set; }
    }
}
