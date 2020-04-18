using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TbaliseLinkReaction
    {
        public TbaliseLinkReaction()
        {
            Tbalise = new HashSet<Tbalise>();
        }

        public byte TbaliseLinkReactionId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Tbalise> Tbalise { get; set; }
    }
}
