using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tinfrastructure
    {
        public short TinfrastructureId { get; set; }
        public string TimetableRef { get; set; }
        public string RollingstockRef { get; set; }
    }
}
