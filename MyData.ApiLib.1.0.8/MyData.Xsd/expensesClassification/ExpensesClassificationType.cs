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
    [XmlTypeAttribute("ExpensesClassificationType", Namespace="https://www.aade.gr/myDATA/expensesClassificaton/v1.0")]
    public partial class ExpensesClassificationType
    {
        
        /// <summary>
        /// <para>Κωδικός Χαρακτηρισμού</para>
        /// </summary>
        [DescriptionAttribute("Κωδικός Χαρακτηρισμού")]
        [XmlElementAttribute("classificationType")]
        public Nullable<ExpensesClassificationTypeclassificationType> classificationType { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Χαρακτηρισμού</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία Χαρακτηρισμού")]
        [XmlElementAttribute("classificationCategory")]
        public Nullable<ExpensesClassificationCategoryType> classificationCategory { get; set; }
        
        /// <summary>
        /// <para>Ποσό Χαρακτηρισμού</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [DescriptionAttribute("Ποσό Χαρακτηρισμού")]
        [RequiredAttribute()]
        [XmlElementAttribute("amount")]
        public decimal amount { get; set; }
        
        /// <summary>
        /// <para>Πόσο Φόρου</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [DescriptionAttribute("Πόσο Φόρου")]
        [XmlElementAttribute("vatAmount")]
        public Nullable<decimal> vatAmount { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία ΦΠΑ</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 8.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία ΦΠΑ")]
        [RangeAttribute(typeof(int), "1", "8")]
        [XmlElementAttribute("vatCategory")]
        public Nullable<int> vatCategory { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Εξαίρεσης ΦΠΑ</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 31.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία Εξαίρεσης ΦΠΑ")]
        [RangeAttribute(typeof(int), "1", "31")]
        [XmlElementAttribute("vatExemptionCategory")]
        public Nullable<int> vatExemptionCategory { get; set; }
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Χαρακτηρισμού</para>
        /// </summary>
        [DescriptionAttribute("Μοναδικός Αριθμός Χαρακτηρισμού")]
        [XmlElementAttribute("id")]
        public Nullable<sbyte> id { get; set; }
    }
}
