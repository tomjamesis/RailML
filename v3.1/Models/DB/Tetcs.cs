using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tetcs
    {
        public short Tetcsid { get; set; }
        public string OnBoardUnitId { get; set; }
        public string SoftwareVersion { get; set; }
        public string SrsVersion { get; set; }
        public bool Level0value { get; set; }
        public bool Level0valueSpecified { get; set; }
        public bool Level1value { get; set; }
        public bool Level1valueSpecified { get; set; }
        public bool Level2value { get; set; }
        public bool Level2valueSpecified { get; set; }
        public bool Level3value { get; set; }
        public bool Level3valueSpecified { get; set; }
    }
}
