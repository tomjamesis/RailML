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
    internal partial interface IABrakeUsage : genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para>DEPRECATED: so far used uncertain value, specific values should now be used instead"</para>
        /// <para>Brake percentage as value of braking performance in relation to vehicle weight</para>
        /// <para xml:lang="en">Maximum inclusive value: 225.</para>
        /// <para xml:lang="en">Minimum inclusive value: 6.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "6", "225")]
        string BrakePercentage
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>to be used instead of the uncertain "brakePercentage" as specific value for the regular case"</para>
        /// <para>Brake percentage as value of braking performance in relation to vehicle weight</para>
        /// <para xml:lang="en">Maximum inclusive value: 225.</para>
        /// <para xml:lang="en">Minimum inclusive value: 6.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "6", "225")]
        string RegularBrakePercentage
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>to be used instead of the uncertain "brakePercentage" as specific value for the emergency case"</para>
        /// <para>Brake percentage as value of braking performance in relation to vehicle weight</para>
        /// <para xml:lang="en">Maximum inclusive value: 225.</para>
        /// <para xml:lang="en">Minimum inclusive value: 6.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "6", "225")]
        string EmergencyBrakePercentage
        {
            get;
            set;
        }
    }
}