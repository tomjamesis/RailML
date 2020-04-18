using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tbalise
    {
        public Tbalise()
        {
            Ebalises = new HashSet<Ebalises>();
        }

        public short TbaliseId { get; set; }
        public string CountryId { get; set; }
        public string GroupId { get; set; }
        public string LinkingAccuracy { get; set; }
        public byte LinkReactionAscendingValue { get; set; }
        public bool LinkReactionAscendingValueSpecified { get; set; }
        public byte LinkReactionDescendingValue { get; set; }
        public bool LinkReactionDescendingValueSpecified { get; set; }
        public string StaticTelegram { get; set; }
        public string Ndx { get; set; }

        public virtual TbaliseLinkReaction LinkReactionAscendingValueNavigation { get; set; }
        public virtual ICollection<Ebalises> Ebalises { get; set; }
    }
}
