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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tControllerTechnologyType", Namespace="https://www.railml.org/schemas/2018")]
    internal enum TControllerTechnologyType
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("manual")]
        Manual,
        
        [System.Xml.Serialization.XmlEnumAttribute("mechanical")]
        Mechanical,
        
        [System.Xml.Serialization.XmlEnumAttribute("electro-mechanical")]
        Electro_Mechanical,
        
        [System.Xml.Serialization.XmlEnumAttribute("electrical")]
        Electrical,
        
        [System.Xml.Serialization.XmlEnumAttribute("electronic")]
        Electronic,
    }
}