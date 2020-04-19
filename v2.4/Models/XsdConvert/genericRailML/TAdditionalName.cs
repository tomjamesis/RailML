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
    [XmlTypeAttribute("tAdditionalName", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EInfraAttr))]
    [XmlIncludeAttribute(typeof(genericRailML.EOcp))]
    [XmlIncludeAttribute(typeof(TElementWithIDAndNameWithoutAny))]
    [XmlIncludeAttribute(typeof(genericRailML.TOcpWithIDAndName))]
    [XmlIncludeAttribute(typeof(genericRailML.TOperationControlPoint))]
    internal partial class TAdditionalName : IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>should be interpreted in its elements' context (e.g. track/name, vehicle/name)</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// <para>should be interpreted in its elements' context, substantiates the name</para>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// <para>natural language identification according to http://www.w3.org/TR/xml/#sec-lang-tag; should always be given</para>
        /// </summary>
        [XmlAttributeAttribute("lang", Namespace="http://www.w3.org/XML/1998/namespace")]
        public string Lang { get; set; }
    }
}