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
    [XmlTypeAttribute("InvoiceRowType", Namespace="http://www.aade.gr/myDATA/invoice/v1.0")]
    public partial class InvoiceRowType
    {
        
        /// <summary>
        /// <para>ΑΑ Γραμμής</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// </summary>
        [DescriptionAttribute("ΑΑ Γραμμής")]
        [RequiredAttribute()]
        [XmlElementAttribute("lineNumber")]
        public int lineNumber { get; set; }
        
        /// <summary>
        /// <para>Είδος Γραμμής</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 7.</para>
        /// </summary>
        [DescriptionAttribute("Είδος Γραμμής")]
        [RangeAttribute(typeof(int), "1", "7")]
        [XmlElementAttribute("recType")]
        public Nullable<int> recType { get; set; }
        
        /// <summary>
        /// <para>Κωδικός Taric</para>
        /// <para xml:lang="en">Minimum length: 10.</para>
        /// <para xml:lang="en">Maximum length: 10.</para>
        /// </summary>
        [DescriptionAttribute("Κωδικός Taric")]
        [MinLengthAttribute(10)]
        [MaxLengthAttribute(10)]
        [XmlElementAttribute("TaricNo")]
        public string TaricNo { get; set; }
        
        /// <summary>
        /// <para>Κωδικός Είδους</para>
        /// <para xml:lang="en">Maximum length: 50.</para>
        /// </summary>
        [DescriptionAttribute("Κωδικός Είδους")]
        [MaxLengthAttribute(50)]
        [XmlElementAttribute("itemCode")]
        public string itemCode { get; set; }
        
        /// <summary>
        /// <para>Περιγραφή Είδους</para>
        /// <para xml:lang="en">Maximum length: 300.</para>
        /// </summary>
        [DescriptionAttribute("Περιγραφή Είδους")]
        [MaxLengthAttribute(300)]
        [XmlElementAttribute("itemDescr")]
        public string itemDescr { get; set; }
        
        /// <summary>
        /// <para>Κωδικός Καυσίμου</para>
        /// </summary>
        [DescriptionAttribute("Κωδικός Καυσίμου")]
        [XmlElementAttribute("fuelCode")]
        public Nullable<FuelCodes> fuelCode { get; set; }
        
        /// <summary>
        /// <para>Ποσότητα</para>
        /// <para xml:lang="en">Minimum exclusive value: 0.</para>
        /// </summary>
        [DescriptionAttribute("Ποσότητα")]
        [XmlElementAttribute("quantity")]
        public Nullable<decimal> quantity { get; set; }
        
        /// <summary>
        /// <para>Είδος Ποσότητας</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 7.</para>
        /// </summary>
        [DescriptionAttribute("Είδος Ποσότητας")]
        [RangeAttribute(typeof(int), "1", "7")]
        [XmlElementAttribute("measurementUnit")]
        public Nullable<int> measurementUnit { get; set; }
        
        /// <summary>
        /// <para>Επισήμανση</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2.</para>
        /// </summary>
        [DescriptionAttribute("Επισήμανση")]
        [RangeAttribute(typeof(int), "1", "2")]
        [XmlElementAttribute("invoiceDetailType")]
        public Nullable<int> invoiceDetailType { get; set; }
        
        /// <summary>
        /// <para>Καθαρή Αξία</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Total number of digits: 15.</para>
        /// </summary>
        [DescriptionAttribute("Καθαρή Αξία")]
        [RequiredAttribute()]
        [XmlElementAttribute("netValue")]
        public decimal netValue { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία ΦΠΑ</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 9.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία ΦΠΑ")]
        [RangeAttribute(typeof(int), "1", "9")]
        [RequiredAttribute()]
        [XmlElementAttribute("vatCategory")]
        public int vatCategory { get; set; }
        
        /// <summary>
        /// <para>Ποσό ΦΠΑ</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Total number of digits: 15.</para>
        /// </summary>
        [DescriptionAttribute("Ποσό ΦΠΑ")]
        [RequiredAttribute()]
        [XmlElementAttribute("vatAmount")]
        public decimal vatAmount { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Αιτίας Εξαίρεσης ΦΠΑ</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 31.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία Αιτίας Εξαίρεσης ΦΠΑ")]
        [RangeAttribute(typeof(int), "1", "31")]
        [XmlElementAttribute("vatExemptionCategory")]
        public Nullable<int> vatExemptionCategory { get; set; }
        
        /// <summary>
        /// <para>ΠΟΛ 1177/2018 Αρ. 27</para>
        /// </summary>
        [DescriptionAttribute("ΠΟΛ 1177/2018 Αρ. 27")]
        [XmlElementAttribute("dienergia")]
        public ShipType dienergia { get; set; }
        
        /// <summary>
        /// <para>Δικαίωμα Έκπτωσης</para>
        /// </summary>
        [DescriptionAttribute("Δικαίωμα Έκπτωσης")]
        [XmlElementAttribute("discountOption")]
        public Nullable<bool> discountOption { get; set; }
        
        /// <summary>
        /// <para>Ποσό Παρ. Φόρου</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Total number of digits: 15.</para>
        /// </summary>
        [DescriptionAttribute("Ποσό Παρ. Φόρου")]
        [XmlElementAttribute("withheldAmount")]
        public Nullable<decimal> withheldAmount { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Συντελεστή  Παρ. Φόρου</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 18.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία Συντελεστή Παρ. Φόρου")]
        [RangeAttribute(typeof(int), "1", "18")]
        [XmlElementAttribute("withheldPercentCategory")]
        public Nullable<int> withheldPercentCategory { get; set; }
        
        /// <summary>
        /// <para>Ποσό Χαρτοσήμου</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Total number of digits: 15.</para>
        /// </summary>
        [DescriptionAttribute("Ποσό Χαρτοσήμου")]
        [XmlElementAttribute("stampDutyAmount")]
        public Nullable<decimal> stampDutyAmount { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Συντελεστή  Χαρτοσήμου</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 4.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία Συντελεστή Χαρτοσήμου")]
        [RangeAttribute(typeof(int), "1", "4")]
        [XmlElementAttribute("stampDutyPercentCategory")]
        public Nullable<int> stampDutyPercentCategory { get; set; }
        
        /// <summary>
        /// <para>Ποσό Τελών</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Total number of digits: 15.</para>
        /// </summary>
        [DescriptionAttribute("Ποσό Τελών")]
        [XmlElementAttribute("feesAmount")]
        public Nullable<decimal> feesAmount { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Συντελεστή Τελών</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 22.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία Συντελεστή Τελών")]
        [RangeAttribute(typeof(int), "1", "22")]
        [XmlElementAttribute("feesPercentCategory")]
        public Nullable<int> feesPercentCategory { get; set; }
        
        /// <summary>
        /// <para>Κατηγορία Συντελεστή Λοιπών Φόρων</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 19.</para>
        /// </summary>
        [DescriptionAttribute("Κατηγορία Συντελεστή Λοιπών Φόρων")]
        [RangeAttribute(typeof(int), "1", "19")]
        [XmlElementAttribute("otherTaxesPercentCategory")]
        public Nullable<int> otherTaxesPercentCategory { get; set; }
        
        /// <summary>
        /// <para>Ποσό Φόρου Διαμονης</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Total number of digits: 15.</para>
        /// </summary>
        [DescriptionAttribute("Ποσό Φόρου Διαμονης")]
        [XmlElementAttribute("otherTaxesAmount")]
        public Nullable<decimal> otherTaxesAmount { get; set; }
        
        /// <summary>
        /// <para>Ποσό Κρατήσεων</para>
        /// <para xml:lang="en">Total number of digits in fraction: 2.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Total number of digits: 15.</para>
        /// </summary>
        [DescriptionAttribute("Ποσό Κρατήσεων")]
        [XmlElementAttribute("deductionsAmount")]
        public Nullable<decimal> deductionsAmount { get; set; }
        
        /// <summary>
        /// <para>Σχόλια Γραμμής</para>
        /// <para>Σχόλια</para>
        /// <para xml:lang="en">Maximum length: 150.</para>
        /// </summary>
        [DescriptionAttribute("Σχόλια Γραμμής")]
        [MaxLengthAttribute(150)]
        [XmlElementAttribute("lineComments")]
        public string lineComments { get; set; }
        
        /// <summary>
        /// <para>Λίστα Χαρακτηρισμών Εσόδων</para>
        /// </summary>
        [DescriptionAttribute("Λίστα Χαρακτηρισμών Εσόδων")]
        [XmlElementAttribute("incomeClassification")]
        public List<MyData.Xsd.IncomeClassificationType> incomeClassification { get; set; }
        
        /// <summary>
        /// <para>Λίστα Χαρακτηρισμού Εξόδων</para>
        /// </summary>
        [DescriptionAttribute("Λίστα Χαρακτηρισμού Εξόδων")]
        [XmlElementAttribute("expensesClassification")]
        public List<MyData.Xsd.ExpensesClassificationType> expensesClassification { get; set; }
        
        /// <summary>
        /// <para>Ποσότητα Θερμοκρασίας 15 βαθμών</para>
        /// <para xml:lang="en">Minimum exclusive value: 0.</para>
        /// </summary>
        [DescriptionAttribute("Ποσότητα Θερμοκρασίας 15 βαθμών")]
        [XmlElementAttribute("quantity15")]
        public Nullable<decimal> quantity15 { get; set; }
        
        /// <summary>
        /// <para>Πλήθος Μονάδας Μέτρησης Τεμάχια Άλλα</para>
        /// </summary>
        [DescriptionAttribute("Πλήθος Μονάδας Μέτρησης Τεμάχια Άλλα")]
        [XmlElementAttribute("otherMeasurementUnitQuantity")]
        public Nullable<int> otherMeasurementUnitQuantity { get; set; }
        
        /// <summary>
        /// <para>Τίτλος Μονάδας Μέτρησης Τεμάχια Άλλα</para>
        /// <para xml:lang="en">Maximum length: 150.</para>
        /// </summary>
        [DescriptionAttribute("Τίτλος Μονάδας Μέτρησης Τεμάχια Άλλα")]
        [MaxLengthAttribute(150)]
        [XmlElementAttribute("otherMeasurementUnitTitle")]
        public string otherMeasurementUnitTitle { get; set; }
    }
}
