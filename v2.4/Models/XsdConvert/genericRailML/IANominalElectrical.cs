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
    /// <summary>
    /// <para>nominal values (voltage + current) of an electrical circuit</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    internal partial interface IANominalElectrical
    {
        
        /// <summary>
        /// <para>nominal voltage of circuit in Volts</para>
        /// <para>generic type for voltage values measured in volt</para>
        /// </summary>
        decimal NominalVoltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>nominal current of circuit in Amps</para>
        /// <para>generic type for electric current values measured in ampere</para>
        /// </summary>
        decimal NominalCurrent
        {
            get;
            set;
        }
    }
}