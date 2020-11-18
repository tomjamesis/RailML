//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.DB
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>container for list of physical curving limits</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tCurvingLimitationType", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ECurvingLimitation))]
    internal partial class TCurvingLimitationType : IACurvingLimitation
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>maximum horizontal curve radius in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("horizontalCurveRadius")]
        public decimal HorizontalCurveRadiusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HorizontalCurveRadius-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HorizontalCurveRadius property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool HorizontalCurveRadiusValueSpecified { get; set; }
        
        /// <summary>
        /// <para>maximum horizontal curve radius in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> HorizontalCurveRadius
        {
            get
            {
                if (this.HorizontalCurveRadiusValueSpecified)
                {
                    return this.HorizontalCurveRadiusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HorizontalCurveRadiusValue = value.GetValueOrDefault();
                this.HorizontalCurveRadiusValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>maximum vertical radius of any crest (de: Kuppe) in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("verticalCrestRadius")]
        public decimal VerticalCrestRadiusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die VerticalCrestRadius-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VerticalCrestRadius property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool VerticalCrestRadiusValueSpecified { get; set; }
        
        /// <summary>
        /// <para>maximum vertical radius of any crest (de: Kuppe) in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> VerticalCrestRadius
        {
            get
            {
                if (this.VerticalCrestRadiusValueSpecified)
                {
                    return this.VerticalCrestRadiusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VerticalCrestRadiusValue = value.GetValueOrDefault();
                this.VerticalCrestRadiusValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>maximum vertical radius of any sag (de: Wanne) in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("verticalSagRadius")]
        public decimal VerticalSagRadiusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die VerticalSagRadius-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the VerticalSagRadius property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool VerticalSagRadiusValueSpecified { get; set; }
        
        /// <summary>
        /// <para>maximum vertical radius of any sag (de: Wanne) in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> VerticalSagRadius
        {
            get
            {
                if (this.VerticalSagRadiusValueSpecified)
                {
                    return this.VerticalSagRadiusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VerticalSagRadiusValue = value.GetValueOrDefault();
                this.VerticalSagRadiusValueSpecified = value.HasValue;
            }
        }
    }
}