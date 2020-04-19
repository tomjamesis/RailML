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
    [XmlTypeAttribute("tOcpPropEquipmentSummary", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TOcpPropEquipmentSummary
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("signalBox")]
        public genericRailML.TInterlockingTypes SignalBoxValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SignalBox-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SignalBox property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SignalBoxValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<genericRailML.TInterlockingTypes> SignalBox
        {
            get
            {
                if (this.SignalBoxValueSpecified)
                {
                    return this.SignalBoxValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SignalBoxValue = value.GetValueOrDefault();
                this.SignalBoxValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private bool _powerstation = false;
        
        [DefaultValueAttribute(false)]
        [XmlAttributeAttribute("powerstation")]
        public bool Powerstation
        {
            get
            {
                return this._powerstation;
            }
            set
            {
                this._powerstation = value;
            }
        }
        
        [XmlIgnoreAttribute()]
        private bool _hasHomeSignals = false;
        
        [DefaultValueAttribute(false)]
        [XmlAttributeAttribute("hasHomeSignals")]
        public bool HasHomeSignals
        {
            get
            {
                return this._hasHomeSignals;
            }
            set
            {
                this._hasHomeSignals = value;
            }
        }
        
        [XmlIgnoreAttribute()]
        private bool _hasStarterSignals = false;
        
        [DefaultValueAttribute(false)]
        [XmlAttributeAttribute("hasStarterSignals")]
        public bool HasStarterSignals
        {
            get
            {
                return this._hasStarterSignals;
            }
            set
            {
                this._hasStarterSignals = value;
            }
        }
        
        [XmlIgnoreAttribute()]
        private bool _hasSwitches = false;
        
        [DefaultValueAttribute(false)]
        [XmlAttributeAttribute("hasSwitches")]
        public bool HasSwitches
        {
            get
            {
                return this._hasSwitches;
            }
            set
            {
                this._hasSwitches = value;
            }
        }
    }
}