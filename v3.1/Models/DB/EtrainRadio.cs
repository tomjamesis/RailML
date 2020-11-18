using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrainRadio
    {
        public EtrainRadio()
        {
            Emonitoring = new HashSet<Emonitoring>();
        }

        public short EtrainRadioId { get; set; }
        public string RadioSystem { get; set; }

        public virtual ICollection<Emonitoring> Emonitoring { get; set; }
    }
}
