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
    
    
    /// <summary>
    /// <para>Χαρατηρισμοί Εσόδων Πρότυπων Παραστατικών ΑΑΔΕ</para>
    /// </summary>
    [DescriptionAttribute("Χαρατηρισμοί Εσόδων Πρότυπων Παραστατικών ΑΑΔΕ")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [SerializableAttribute()]
    [XmlTypeAttribute("IncomeClassificationsDoc", Namespace="https://www.aade.gr/myDATA/incomeClassificaton/v1.0", AnonymousType=true)]
    [XmlRootAttribute("IncomeClassificationsDoc", Namespace="https://www.aade.gr/myDATA/incomeClassificaton/v1.0")]
    public partial class IncomeClassificationsDoc
    {
        
        [RequiredAttribute()]
        [XmlElementAttribute("incomeInvoiceClassification")]
        public List<InvoiceIncomeClassificationType> incomeInvoiceClassification { get; set; }
    }
}
