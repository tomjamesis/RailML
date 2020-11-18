using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainGroup
    {
        public short TtrainGroupId { get; set; }
        public string Type { get; set; }
        public string TrainNumber { get; set; }
        public string ProcessStatus { get; set; }
    }
}
