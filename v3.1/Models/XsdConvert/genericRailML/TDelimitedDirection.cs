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
    
    
    /// <summary>
    /// <para>generic type for more constrained direction statements</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tDelimitedDirection", Namespace="https://www.railml.org/schemas/2018")]
    internal enum TDelimitedDirection
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("up")]
        Up,
        
        [System.Xml.Serialization.XmlEnumAttribute("down")]
        Down,
        
        [System.Xml.Serialization.XmlEnumAttribute("unknown")]
        Unknown,
    }
}