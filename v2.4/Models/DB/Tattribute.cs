using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tattribute
    {
        public Tattribute()
        {
            Eattributes = new HashSet<Eattributes>();
        }

        public long TattributeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Eattributes> Eattributes { get; set; }
    }
}
