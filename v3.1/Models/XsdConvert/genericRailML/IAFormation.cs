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
    internal partial interface IAFormation
    {
        
        /// <summary>
        /// <para>number of similar formations forming that train</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string FormationCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>entire length of the formation (shall be in accordance with the sum of single vehicles)</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> Length
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>allowed maximum speed for the entire formation (shall be in accordance with single vehicle speed values)</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        System.Nullable<decimal> Speed
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED: weight in metrical tons of the entire formation (shall be in accordance with the sum of single vehicles)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> Weight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>gross weight (vehicles plus payload) in metrical tons of the entire formation (shall be in accordance with the sum of single vehicles)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> BruttoWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>net weight (payload only) in metrical tons of the entire formation (shall be in accordance with the sum of single vehicles)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> NettoWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>tare weight (empty vehicles) in metrical tons of the entire formation (shall be in accordance with the sum of single vehicles)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> TareWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the international train category number as specified on page 38 in ERA_ERTMS_040001 "Assignment of values to ETCS variables" v1.9 from 10/07/12</para>
        /// <para>the international train category number as specified on page 38 in ERA_ERTMS_040001 "Assignment of values to ETCS variables" v1.9 from 10/07/12</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 15.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "15")]
        string EtcsTrainCategory
        {
            get;
            set;
        }
    }
}