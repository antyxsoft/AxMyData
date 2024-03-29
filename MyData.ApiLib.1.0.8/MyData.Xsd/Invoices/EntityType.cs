//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace MyData.Xsd
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [SerializableAttribute()]
    [XmlTypeAttribute("EntityType", Namespace="http://www.aade.gr/myDATA/invoice/v1.0")]
    public partial class EntityType
    {
        
        /// <summary>
        /// <para>Κατηγορία</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 6.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία")]
        [RangeAttribute(typeof(int), "1", "6")]
        [RequiredAttribute()]
        [XmlElementAttribute("type")]
        public int type { get; set; }
        
        /// <summary>
        /// <para>Στοιχεία Οντότητας</para>
        /// </summary>
        [DescriptionAttribute("Στοιχεία Οντότητας")]
        [RequiredAttribute()]
        [XmlElementAttribute("entityData")]
        public PartyType entityData { get; set; }
    }
}
