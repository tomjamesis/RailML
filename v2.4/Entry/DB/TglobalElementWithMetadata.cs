using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TglobalElementWithMetadata
    {
        public short TglobalElementWithMetadataId { get; set; }
        public long Metadata { get; set; }
        public string Version { get; set; }
        public string Base { get; set; }

        public virtual ElementContainer MetadataNavigation { get; set; }
    }
}
