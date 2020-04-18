using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TplacedElementWithLength
    {
        public short TplacedElementWithLengthId { get; set; }
        public long States { get; set; }
        public decimal LengthValue { get; set; }
        public bool LengthValueSpecified { get; set; }

        public virtual TstatesWithLength StatesNavigation { get; set; }
    }
}
