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
    [XmlTypeAttribute("tOperationControlPoint", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EOcp))]
    internal partial class TOperationControlPoint : TOcpWithIDAndName
    {
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TElementRefInGroup> _controllerRef;
        
        /// <summary>
        /// <para>reference from OCP to a Controller</para>
        /// </summary>
        [XmlElementAttribute("controllerRef", Order=0)]
        public Collection<genericRailML.TElementRefInGroup> ControllerRef
        {
            get
            {
                return this._controllerRef;
            }
            private set
            {
                this._controllerRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ControllerRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ControllerRef collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool ControllerRefSpecified
        {
            get
            {
                return (this.ControllerRef.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TOperationControlPoint" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TOperationControlPoint" /> class.</para>
        /// </summary>
        public TOperationControlPoint()
        {
            this._controllerRef = new Collection<genericRailML.TElementRefInGroup>();
        }
        
        /// <summary>
        /// <para>DEPRECATED: use the 'designator' with its parameters 'register' and 'entry' instead</para>
        /// </summary>
        [XmlAttributeAttribute("number")]
        public string Number { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: use the 'designator' with its parameters 'register' and 'entry' instead</para>
        /// </summary>
        [XmlAttributeAttribute("abbrevation")]
        public string Abbrevation { get; set; }
        
        /// <summary>
        /// <para>timezone as defined in the tz database, e.g. "America/New_York"</para>
        /// </summary>
        [XmlAttributeAttribute("timezone")]
        public string Timezone { get; set; }
        
        /// <summary>
        /// <para>references the one and only parent ocp of this ocp</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("parentOcpRef")]
        public string ParentOcpRef { get; set; }
    }
}