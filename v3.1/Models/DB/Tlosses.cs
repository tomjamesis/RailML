using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tlosses
    {
        public Tlosses()
        {
            EtractionMotor = new HashSet<EtractionMotor>();
        }

        public short TlossesId { get; set; }

        public virtual ICollection<EtractionMotor> EtractionMotor { get; set; }
    }
}
