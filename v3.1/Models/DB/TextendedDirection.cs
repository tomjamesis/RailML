using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TextendedDirection
    {
        public TextendedDirection()
        {
            Ttrack = new HashSet<Ttrack>();
        }

        public byte TextendedDirectionId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Ttrack> Ttrack { get; set; }
    }
}
