//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.XsdConvert.genericRailML
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("eTrackTopology", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class ETrackTopology
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>this node marks the begin of the track defined by its relative position pos=0</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trackBegin", Order=0)]
        public ETrackBegin TrackBegin { get; set; }
        
        /// <summary>
        /// <para>this node marks the end of the track defined by its relative position pos=(length of track)</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trackEnd", Order=1)]
        public ETrackEnd TrackEnd { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("mileageChanges", Order=2)]
        public EMileageChanges MileageChanges { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("connections", Order=3)]
        public EConnections Connections { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("crossSections", Order=4)]
        public ECrossSections CrossSections { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("borders", Order=5)]
        public EBorder Borders { get; set; }
    }
}