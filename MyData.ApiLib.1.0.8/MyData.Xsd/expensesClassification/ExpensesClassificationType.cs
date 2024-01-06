//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0
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
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("ExpensesClassificationType", Namespace="https://www.aade.gr/myDATA/expensesClassificaton/v1.0")]
    public partial class ExpensesClassificationType
    {
        
        /// <summary>
        /// <para>Κωδικός Χαρακτηρισμού</para>
        /// </summary>
        [XmlElementAttribute("classificationType")]
        public Nullable<ExpensesClassificationTypeclassificationType> classificationType { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Χαρακτηρισμού</para>
        /// </summary>
        [XmlElementAttribute("classificationCategory")]
        public Nullable<ExpensesClassificationCategoryType> classificationCategory { get; set; }
        
        /// <summary>
        /// <para>Ποσό Χαρακτηρισμού</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [RequiredAttribute()]
        [XmlElementAttribute("amount")]
        public decimal amount { get; set; }
        
        /// <summary>
        /// <para>Πόσο Φόρου</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [XmlElementAttribute("vatAmount")]
        public Nullable<decimal> vatAmount { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία ΦΠΑ</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 8.</para>
        /// </summary>
        [RangeAttribute(typeof(int), "1", "8")]
        [XmlElementAttribute("vatCategory")]
        public Nullable<int> vatCategory { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Εξαίρεσης ΦΠΑ</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 31.</para>
        /// </summary>
        [RangeAttribute(typeof(int), "1", "31")]
        [XmlElementAttribute("vatExemptionCategory")]
        public Nullable<int> vatExemptionCategory { get; set; }
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Χαρακτηρισμού</para>
        /// </summary>
        [XmlElementAttribute("id")]
        public Nullable<sbyte> id { get; set; }
    }
}
