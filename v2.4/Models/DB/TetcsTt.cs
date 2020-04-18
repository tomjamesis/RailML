using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TetcsTt
    {
        public TetcsTt()
        {
            Eequipment = new HashSet<Eequipment>();
        }

        public long TetcsTtid { get; set; }
        public string SrsVersion { get; set; }
        public bool Level0value { get; set; }
        public bool Level0valueSpecified { get; set; }
        public bool Level1value { get; set; }
        public bool Level1valueSpecified { get; set; }
        public bool Level2value { get; set; }
        public bool Level2valueSpecified { get; set; }
        public bool Level3value { get; set; }
        public bool Level3valueSpecified { get; set; }

        public virtual ICollection<Eequipment> Eequipment { get; set; }
    }
}
