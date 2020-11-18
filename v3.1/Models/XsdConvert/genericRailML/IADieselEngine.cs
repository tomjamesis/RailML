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
    internal partial interface IADieselEngine
    {
        
        /// <summary>
        /// <para>nominal power per diesel engine in Watt</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        System.Nullable<decimal> NominalPower
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>nominal power per diesel engine in Watt leftover for auxiliary supply</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        System.Nullable<decimal> AvailableAuxiliaryPower
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>fuel capacity of the entire diesel tank in liters</para>
        /// <para>generic type for volume values measured in litre</para>
        /// </summary>
        System.Nullable<decimal> FuelCapacity
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>average efficiency of the diesel engine in the range 0..1</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1")]
        System.Nullable<decimal> MeanEfficiency
        {
            get;
            set;
        }
    }
}