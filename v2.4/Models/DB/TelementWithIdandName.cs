using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TelementWithIdandName
    {
        public long AdditionalName { get; set; }
        public string Any { get; set; }
        public string TelementWithIdandNameId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lang { get; set; }

        public virtual TadditionalName AdditionalNameNavigation { get; set; }
    }
}
