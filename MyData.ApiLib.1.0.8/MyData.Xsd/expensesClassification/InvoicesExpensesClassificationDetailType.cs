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
    [XmlTypeAttribute("InvoicesExpensesClassificationDetailType", Namespace="https://www.aade.gr/myDATA/expensesClassificaton/v1.0")]
    public partial class InvoicesExpensesClassificationDetailType
    {
        
        /// <summary>
        /// <para>Γραμμή Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Γραμμή Παραστατικού")]
        [RequiredAttribute()]
        [XmlElementAttribute("lineNumber")]
        public int lineNumber { get; set; }
        
        /// <summary>
        /// <para>Λίστα Χαρακτηρισμών Εσόδων</para>
        /// </summary>
        [DescriptionAttribute("Λίστα Χαρακτηρισμών Εσόδων")]
        [RequiredAttribute()]
        [XmlElementAttribute("expensesClassificationDetailData")]
        public List<ExpensesClassificationType> expensesClassificationDetailData { get; set; }
    }
}
