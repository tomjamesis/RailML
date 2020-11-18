using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TadditionalName
    {
        public TadditionalName()
        {
            TelementWithIdandName = new HashSet<TelementWithIdandName>();
        }

        public long TadditionalNameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }

        public virtual ICollection<TelementWithIdandName> TelementWithIdandName { get; set; }
    }
}
