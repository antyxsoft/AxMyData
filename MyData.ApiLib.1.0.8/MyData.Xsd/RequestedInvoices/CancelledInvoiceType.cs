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
    [XmlTypeAttribute("CancelledInvoiceType", Namespace="http://www.aade.gr/myDATA/invoice/v1.0")]
    public partial class CancelledInvoiceType
    {
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Καταχώρησης του ακυρωμένου Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Μοναδικός Αριθμός Καταχώρησης του ακυρωμένου Παραστατικού")]
        [RequiredAttribute()]
        [XmlElementAttribute("invoiceMark")]
        public long invoiceMark { get; set; }
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Καταχώρησης της Ακύρωσης</para>
        /// </summary>
        [DescriptionAttribute("Μοναδικός Αριθμός Καταχώρησης της Ακύρωσης")]
        [RequiredAttribute()]
        [XmlElementAttribute("cancellationMark")]
        public long cancellationMark { get; set; }
        
        /// <summary>
        /// <para>Ημερομηνία Ακύρωσης Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Ημερομηνία Ακύρωσης Παραστατικού")]
        [RequiredAttribute()]
        [XmlElementAttribute("cancellationDate", DataType="date")]
        public DateTime cancellationDate { get; set; }
    }
}
