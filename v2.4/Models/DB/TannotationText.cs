using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TannotationText
    {
        public TannotationText()
        {
            Eannotation = new HashSet<Eannotation>();
        }

        public string Value { get; set; }
        public long TannotationTextId { get; set; }
        public string Lang { get; set; }

        public virtual ICollection<Eannotation> Eannotation { get; set; }
    }
}
