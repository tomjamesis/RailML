using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tderailer
    {
        public Tderailer()
        {
            Ederailers = new HashSet<Ederailers>();
        }

        public short TderailerId { get; set; }
        public byte DerailSideValue { get; set; }
        public bool DerailSideValueSpecified { get; set; }
        public byte KindValue { get; set; }
        public bool KindValueSpecified { get; set; }
        public string Model { get; set; }

        public virtual Tside DerailSideValueNavigation { get; set; }
        public virtual TderailKind KindValueNavigation { get; set; }
        public virtual ICollection<Ederailers> Ederailers { get; set; }
    }
}
