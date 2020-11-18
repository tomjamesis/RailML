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
    [System.Xml.Serialization.XmlTypeAttribute("tAuxiliarySupply", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EAuxiliarySupply))]
    internal partial class TAuxiliarySupply : IAAuxiliarySupply
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>power consumption of constant load by auxiliary equipment in Watt (permanent)</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("power")]
        public decimal Power { get; set; }
        
        /// <summary>
        /// <para>phase angle phi of constant power of auxiliary load between -180..+180</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("powerPhi")]
        public decimal PowerPhiValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PowerPhi-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PowerPhi property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PowerPhiValueSpecified { get; set; }
        
        /// <summary>
        /// <para>phase angle phi of constant power of auxiliary load between -180..+180</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> PowerPhi
        {
            get
            {
                if (this.PowerPhiValueSpecified)
                {
                    return this.PowerPhiValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PowerPhiValue = value.GetValueOrDefault();
                this.PowerPhiValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>resistance of constant load by auxiliary equipment in Ohm</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("resistance")]
        public decimal ResistanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Resistance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Resistance property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ResistanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>resistance of constant load by auxiliary equipment in Ohm</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> Resistance
        {
            get
            {
                if (this.ResistanceValueSpecified)
                {
                    return this.ResistanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ResistanceValue = value.GetValueOrDefault();
                this.ResistanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>power consumption of constant load by auxiliary equipment in Watt (only during braking mode)</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("powerBraking")]
        public decimal PowerBrakingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PowerBraking-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PowerBraking property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PowerBrakingValueSpecified { get; set; }
        
        /// <summary>
        /// <para>power consumption of constant load by auxiliary equipment in Watt (only during braking mode)</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> PowerBraking
        {
            get
            {
                if (this.PowerBrakingValueSpecified)
                {
                    return this.PowerBrakingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PowerBrakingValue = value.GetValueOrDefault();
                this.PowerBrakingValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>phase angle phi of constant power of auxiliary load between -180..+180 (only during braking mode)</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("powerPhiBraking")]
        public decimal PowerPhiBrakingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PowerPhiBraking-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PowerPhiBraking property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PowerPhiBrakingValueSpecified { get; set; }
        
        /// <summary>
        /// <para>phase angle phi of constant power of auxiliary load between -180..+180 (only during braking mode)</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> PowerPhiBraking
        {
            get
            {
                if (this.PowerPhiBrakingValueSpecified)
                {
                    return this.PowerPhiBrakingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PowerPhiBrakingValue = value.GetValueOrDefault();
                this.PowerPhiBrakingValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>resistance of constant load by auxiliary equipment in Ohm (only during braking mode)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("resistanceBraking")]
        public decimal ResistanceBrakingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ResistanceBraking-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ResistanceBraking property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ResistanceBrakingValueSpecified { get; set; }
        
        /// <summary>
        /// <para>resistance of constant load by auxiliary equipment in Ohm (only during braking mode)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ResistanceBraking
        {
            get
            {
                if (this.ResistanceBrakingValueSpecified)
                {
                    return this.ResistanceBrakingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ResistanceBrakingValue = value.GetValueOrDefault();
                this.ResistanceBrakingValueSpecified = value.HasValue;
            }
        }
    }
}