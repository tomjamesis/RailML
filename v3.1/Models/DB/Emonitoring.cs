using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Emonitoring
    {
        public Emonitoring()
        {
            Eengine = new HashSet<Eengine>();
        }

        public short EmonitoringId { get; set; }
        public short Etcs { get; set; }
        public short NationalSystem { get; set; }
        public short TrainRadio { get; set; }
        public short OtherEquipment { get; set; }

        public virtual Eetcs EtcsNavigation { get; set; }
        public virtual TnationalSystem NationalSystemNavigation { get; set; }
        public virtual TotherEquipment OtherEquipmentNavigation { get; set; }
        public virtual EtrainRadio TrainRadioNavigation { get; set; }
        public virtual ICollection<Eengine> Eengine { get; set; }
    }
}
