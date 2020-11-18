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
    internal partial interface IACirculation
    {
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string BlockRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>if not defined: operatingPeriodRef must be defined</para>
        /// </summary>
        System.Nullable<System.DateTime> StartDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>if not defined: as operatingPeriod or open end</para>
        /// </summary>
        System.Nullable<System.DateTime> EndDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>if not defined: daily from startDate to endDate</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string OperatingPeriodRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>for abstract circulations without start/endDate</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string RepeatCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>indicating the right vehicle number (de: Fahrzeugnummer) within the circulations</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string VehicleCounter
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>indicating the right vehicle group number (de: Gruppennummer) within the circulations</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string VehicleGroupCounter
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string NextBlockRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>there has to be an information to which operation day of the next block the current block should be linked to. A vehicle can make a standstill for several days but the defined next block inside of the circulation may run every day</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string NextOperatingPeriodRef
        {
            get;
            set;
        }
    }
}