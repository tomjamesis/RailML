using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TdriversCabType
    {
        public TdriversCabType()
        {
            Ewagon = new HashSet<Ewagon>();
        }

        public long TdriversCabTypeId { get; set; }
        public string OrderNumber { get; set; }
        public byte Position { get; set; }
        public string AcousticSignaller { get; set; }

        public virtual TcabPositionType PositionNavigation { get; set; }
        public virtual ICollection<Ewagon> Ewagon { get; set; }
    }
}
