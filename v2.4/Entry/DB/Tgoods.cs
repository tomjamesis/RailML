using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tgoods
    {
        public long TgoodsId { get; set; }
        public decimal LoadValue { get; set; }
        public bool LoadValueSpecified { get; set; }
        public decimal LoadAreaValue { get; set; }
        public bool LoadAreaValueSpecified { get; set; }
        public decimal VolumeValue { get; set; }
        public bool VolumeValueSpecified { get; set; }
        public string FreightCarType { get; set; }
        public string FreightCarUictype { get; set; }
    }
}
