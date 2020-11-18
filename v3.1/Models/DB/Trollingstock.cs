using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Trollingstock
    {
        public short TrollingstockId { get; set; }
        public string TimetableRef { get; set; }
        public string InfrastructureRef { get; set; }
    }
}
