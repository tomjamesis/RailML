//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Models.XsdConvert.genericRailML
{
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("infrastructure", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("infrastructure", Namespace="https://www.railml.org/schemas/2018")]
    internal partial class Infrastructure : genericRailML.TInfrastructure
    {
        
        [XmlElementAttribute("infraAttrGroups", Order=0)]
        public EInfraAttrGroup InfraAttrGroups { get; set; }
        
        [XmlElementAttribute("tracks", Order=1)]
        public ETracks Tracks { get; set; }
        
        [XmlElementAttribute("trackGroups", Order=2)]
        public ETrackGroups TrackGroups { get; set; }
        
        [XmlElementAttribute("operationControlPoints", Order=3)]
        public EOperationControlPoints OperationControlPoints { get; set; }
        
        [XmlElementAttribute("controllers", Order=4)]
        public EControllers Controllers { get; set; }
        
        [XmlElementAttribute("speedProfiles", Order=5)]
        public ESpeedProfiles SpeedProfiles { get; set; }
        
        /// <summary>
        /// <para>Container to define disabled/enabled status of infrastructure</para>
        /// </summary>
        [XmlElementAttribute("states", Order=6)]
        public genericRailML.TStates States { get; set; }
    }
}