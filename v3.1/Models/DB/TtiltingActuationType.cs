using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtiltingActuationType
    {
        public TtiltingActuationType()
        {
            Ttilting = new HashSet<Ttilting>();
        }

        public byte TtiltingActuationTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Ttilting> Ttilting { get; set; }
    }
}
