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
    [SerializableAttribute()]
    [XmlTypeAttribute("eMonitoring", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EMonitoring : genericRailML.TMonitoring
    {
        
        /// <summary>
        /// <para>capabilities with respect to European Train Control System</para>
        /// </summary>
        [XmlElementAttribute("etcs", Order=0)]
        public EETCS Etcs { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TNationalSystem> _nationalSystem;
        
        /// <summary>
        /// <para>list of installed national train protection/control systems</para>
        /// </summary>
        [XmlElementAttribute("nationalSystem", Order=1)]
        public Collection<genericRailML.TNationalSystem> NationalSystem
        {
            get
            {
                return this._nationalSystem;
            }
            private set
            {
                this._nationalSystem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NationalSystem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NationalSystem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool NationalSystemSpecified
        {
            get
            {
                return (this.NationalSystem.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EMonitoring" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EMonitoring" /> class.</para>
        /// </summary>
        public EMonitoring()
        {
            this._nationalSystem = new Collection<genericRailML.TNationalSystem>();
            this._trainRadio = new Collection<ETrainRadio>();
            this._otherEquipment = new Collection<genericRailML.TOtherEquipment>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<ETrainRadio> _trainRadio;
        
        /// <summary>
        /// <para>list of installed train radio systems for communication</para>
        /// </summary>
        [XmlElementAttribute("trainRadio", Order=2)]
        public Collection<ETrainRadio> TrainRadio
        {
            get
            {
                return this._trainRadio;
            }
            private set
            {
                this._trainRadio = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainRadio-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TrainRadio collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool TrainRadioSpecified
        {
            get
            {
                return (this.TrainRadio.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TOtherEquipment> _otherEquipment;
        
        /// <summary>
        /// <para>list of other (non-safety) installed train equipment</para>
        /// </summary>
        [XmlElementAttribute("otherEquipment", Order=3)]
        public Collection<genericRailML.TOtherEquipment> OtherEquipment
        {
            get
            {
                return this._otherEquipment;
            }
            private set
            {
                this._otherEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OtherEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OtherEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool OtherEquipmentSpecified
        {
            get
            {
                return (this.OtherEquipment.Count != 0);
            }
        }
    }
}