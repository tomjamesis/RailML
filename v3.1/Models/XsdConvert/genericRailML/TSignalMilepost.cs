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
    [System.Xml.Serialization.XmlTypeAttribute("tSignalMilepost", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TSignalMilepost : TSignalBase
    {
        
        /// <summary>
        /// <para>mileage value printed on the milepost</para>
        /// <para>applies as basic type for inheritance, should not be used directly because of missing unit of measure</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("shownValue")]
        public decimal ShownValueValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ShownValue-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ShownValue property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ShownValueValueSpecified { get; set; }
        
        /// <summary>
        /// <para>mileage value printed on the milepost</para>
        /// <para>applies as basic type for inheritance, should not be used directly because of missing unit of measure</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ShownValue
        {
            get
            {
                if (this.ShownValueValueSpecified)
                {
                    return this.ShownValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ShownValueValue = value.GetValueOrDefault();
                this.ShownValueValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>any remark that is printed on the milepost, e.g. for documenting a mileage gap</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("shownRemark")]
        public string ShownRemark { get; set; }
        
        /// <summary>
        /// <para>reference to a mileageChange element</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("mileageChangeRef")]
        public string MileageChangeRef { get; set; }
        
        /// <summary>
        /// <para>reference to a line, for which the milepost is valid</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lineRef")]
        public string LineRef { get; set; }
    }
}