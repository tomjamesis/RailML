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
    [XmlTypeAttribute("railml", Namespace="https://www.railml.org/schemas/2018", AnonymousType=true)]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("railml", Namespace="https://www.railml.org/schemas/2018")]
    internal partial class Railml
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlElementAttribute("metadata", Order=0)]
        public genericRailML.TMetadata Metadata { get; set; }
        
        /// <summary>
        /// <para>"subschema Infrastructure (IS)" can be outsourced in extra file and imported with xi:include mechanism</para>
        /// </summary>
        [XmlElementAttribute("infrastructure", Order=1)]
        public genericRailML.Infrastructure Infrastructure { get; set; }
        
        /// <summary>
        /// <para>use this branch to model explicit visualizations of infrastructure data</para>
        /// </summary>
        [XmlElementAttribute("infrastructureVisualizations", Order=2)]
        public genericRailML.InfrastructureVisualizations InfrastructureVisualizations { get; set; }
        
        /// <summary>
        /// <para>"subschema Rollingstock (RS)" can be outsourced in extra file and imported with xi:include mechanism</para>
        /// </summary>
        [XmlElementAttribute("rollingstock", Order=3)]
        public genericRailML.Rollingstock Rollingstock { get; set; }
        
        /// <summary>
        /// <para>"subschema Timetable (TT)" can be outsourced in extra file and imported with xi:include mechanism</para>
        /// </summary>
        [XmlElementAttribute("timetable", Order=4)]
        public genericRailML.Timetable Timetable { get; set; }
        
        /// <summary>
        /// <para>supported railML version should be declared for software compatibility reasons, valid for all subschemas, don't mix railML versions between subschemas in one XML file</para>
        /// <para>Version Number is some official release number, rather than any internal numbering from an version control system</para>
        /// <para>Allows two part or three part version numbers, 1.0 up to 99.99, or 1.0.1 up to 99.99.99</para>
        /// <para>Allows additional SVN release numbers for testing unofficial releases: 1.1r4 or 2.0r271</para>
        /// <para xml:lang="en">Pattern: [1-9][0-9]?\.([0-9]|[1-9][0-9])(\.[1-9][0-9]?)?(r[1-9][0-9]?[0-9]?)?.</para>
        /// </summary>
        [RegularExpressionAttribute("[1-9][0-9]?\\.([0-9]|[1-9][0-9])(\\.[1-9][0-9]?)?(r[1-9][0-9]?[0-9]?)?")]
        [XmlAttributeAttribute("version")]
        public string Version { get; set; }
    }
}