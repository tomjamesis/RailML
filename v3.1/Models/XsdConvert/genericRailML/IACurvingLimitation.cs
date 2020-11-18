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
    internal partial interface IACurvingLimitation
    {
        
        /// <summary>
        /// <para>maximum horizontal curve radius in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> HorizontalCurveRadius
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum vertical radius of any crest (de: Kuppe) in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> VerticalCrestRadius
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum vertical radius of any sag (de: Wanne) in metres allowed for the vehicle running</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> VerticalSagRadius
        {
            get;
            set;
        }
    }
}