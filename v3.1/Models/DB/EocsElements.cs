using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EocsElements
    {
        public EocsElements()
        {
            Etrack = new HashSet<Etrack>();
        }

        public long EocsElementsId { get; set; }
        public long Signals { get; set; }
        public long TrainDetectionElements { get; set; }
        public long Balises { get; set; }
        public long TrainProtectionElements { get; set; }
        public long StopPosts { get; set; }
        public long Derailers { get; set; }
        public long TrainRadioChanges { get; set; }
        public long Locks { get; set; }
        public string Any { get; set; }

        public virtual Ebalises BalisesNavigation { get; set; }
        public virtual Ederailers DerailersNavigation { get; set; }
        public virtual Elocks LocksNavigation { get; set; }
        public virtual Esignals SignalsNavigation { get; set; }
        public virtual EstopPosts StopPostsNavigation { get; set; }
        public virtual EtrainDetectionElements TrainDetectionElementsNavigation { get; set; }
        public virtual EtrainProtectionElements TrainProtectionElementsNavigation { get; set; }
        public virtual EtrainRadioChanges TrainRadioChangesNavigation { get; set; }
        public virtual ICollection<Etrack> Etrack { get; set; }
    }
}
