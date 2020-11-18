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
    [System.Xml.Serialization.XmlTypeAttribute("TBasicBrakeTypeAuxiliaryBrakes", Namespace="https://www.railml.org/schemas/2018", AnonymousType=true)]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TBasicBrakeTypeAuxiliaryBrakes : IAAuxiliaryBrakes, genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("brakeUse")]
        public TBrakeUse BrakeUseValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BrakeUse-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BrakeUse property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool BrakeUseValueSpecified { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<TBrakeUse> BrakeUse
        {
            get
            {
                if (this.BrakeUseValueSpecified)
                {
                    return this.BrakeUseValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BrakeUseValue = value.GetValueOrDefault();
                this.BrakeUseValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>de: hydro-dynamisch</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("H")]
        public bool HValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die H-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the H property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool HValueSpecified { get; set; }
        
        /// <summary>
        /// <para>de: hydro-dynamisch</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> H
        {
            get
            {
                if (this.HValueSpecified)
                {
                    return this.HValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HValue = value.GetValueOrDefault();
                this.HValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>de: elektro-motorisch</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("E")]
        public bool EValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die E-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the E property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool EValueSpecified { get; set; }
        
        /// <summary>
        /// <para>de: elektro-motorisch</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> E
        {
            get
            {
                if (this.EValueSpecified)
                {
                    return this.EValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EValue = value.GetValueOrDefault();
                this.EValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>de: Magnetschienenbremse</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Mg")]
        public bool MgValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Mg-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Mg property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MgValueSpecified { get; set; }
        
        /// <summary>
        /// <para>de: Magnetschienenbremse</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Mg
        {
            get
            {
                if (this.MgValueSpecified)
                {
                    return this.MgValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MgValue = value.GetValueOrDefault();
                this.MgValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>de: Wirbelstrombremse</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("Wb")]
        public bool WbValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Wb-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Wb property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool WbValueSpecified { get; set; }
        
        /// <summary>
        /// <para>de: Wirbelstrombremse</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Wb
        {
            get
            {
                if (this.WbValueSpecified)
                {
                    return this.WbValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.WbValue = value.GetValueOrDefault();
                this.WbValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>de: elektro-pneumatisch</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ep")]
        public bool EpValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Ep-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Ep property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool EpValueSpecified { get; set; }
        
        /// <summary>
        /// <para>de: elektro-pneumatisch</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Ep
        {
            get
            {
                if (this.EpValueSpecified)
                {
                    return this.EpValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EpValue = value.GetValueOrDefault();
                this.EpValueSpecified = value.HasValue;
            }
        }
    }
}