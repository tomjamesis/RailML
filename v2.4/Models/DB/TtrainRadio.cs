using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainRadio
    {
        public short TtrainRadioId { get; set; }
        public string OnBoardUnitId { get; set; }
        public string SoftwareVersion { get; set; }
        public string Modulation { get; set; }
    }
}
