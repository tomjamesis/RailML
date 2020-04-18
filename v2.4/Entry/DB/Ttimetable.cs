using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Ttimetable
    {
        public short TtimetableId { get; set; }
        public string InfrastructureRef { get; set; }
        public string RollingstockRef { get; set; }
    }
}
