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
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    internal partial interface IARackTraction
    {
        
        /// <summary>
        /// <para>number of cog wheels on the vehicle</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string Number
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>kind of rack system used</para>
        /// </summary>
        string RackSystem
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>flag, whether the cog wheel(s) is(are) resilently suspended</para>
        /// </summary>
        bool ResilentCogWheel
        {
            get;
            set;
        }
    }
}