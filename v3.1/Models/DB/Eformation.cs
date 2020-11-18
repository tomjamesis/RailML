using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eformation
    {
        public Eformation()
        {
            Eformations = new HashSet<Eformations>();
        }

        public short EformationId { get; set; }
        public long TrainOrder { get; set; }
        public long CategoryRef { get; set; }
        public long TrainEngine { get; set; }
        public long TrainBrakes { get; set; }
        public long TrainBrakeOperation { get; set; }
        public short TrainResistance { get; set; }
        public long SpeedProfileRef { get; set; }
        public long TechnicalStopActivity { get; set; }

        public virtual TelementWithReference CategoryRefNavigation { get; set; }
        public virtual TspeedProfileRefRs SpeedProfileRefNavigation { get; set; }
        public virtual TtechnicalStopActivity TechnicalStopActivityNavigation { get; set; }
        public virtual TbasicBrakeOperation TrainBrakeOperationNavigation { get; set; }
        public virtual TbasicBrakeType TrainBrakesNavigation { get; set; }
        public virtual TtrainEngine TrainEngineNavigation { get; set; }
        public virtual EtrainOrder TrainOrderNavigation { get; set; }
        public virtual TtrainResistance TrainResistanceNavigation { get; set; }
        public virtual ICollection<Eformations> Eformations { get; set; }
    }
}
