//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1057.0
namespace MyData.Xsd
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1057.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("InvoiceExpensesClassificationType", Namespace="https://www.aade.gr/myDATA/expensesClassificaton/v1.0")]
    public partial class InvoiceExpensesClassificationType
    {
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Καταχώρησης Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Μοναδικός Αριθμός Καταχώρησης Παραστατικού")]
        [RequiredAttribute()]
        [XmlElementAttribute("invoiceMark")]
        public long invoiceMark { get; set; }
        
        /// <summary>
        /// <para>Αποδεικτικό Λήψης Χαρακτηρισμού Εξόδων. Συμπληρώνεται από την Υπηρεσία</para>
        /// </summary>
        [DescriptionAttribute("Αποδεικτικό Λήψης Χαρακτηρισμού Εξόδων. Συμπληρώνεται από την Υπηρεσία")]
        [XmlElementAttribute("classificationMark")]
        public long classificationMark { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die classificationMark-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the classificationMark property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool classificationMarkSpecified { get; set; }
        
        /// <summary>
        /// <para>ΑΦΜ Οντότητας Αναφοράς</para>
        /// </summary>
        [DescriptionAttribute("ΑΦΜ Οντότητας Αναφοράς")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("entityVatNumber")]
        public string entityVatNumber { get; set; }
        
        /// <summary>
        /// <para>Αιτιολογία Συναλλαγής</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 2.</para>
        /// </summary>
        [DescriptionAttribute("Αιτιολογία Συναλλαγής")]
        [RangeAttribute(typeof(int), "1", "2")]
        [XmlElementAttribute("transactionMode")]
        public int transactionMode { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die transactionMode-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the transactionMode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool transactionModeSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<InvoicesExpensesClassificationDetailType> _invoicesExpensesClassificationDetails;
        
        [XmlElementAttribute("invoicesExpensesClassificationDetails")]
        public List<InvoicesExpensesClassificationDetailType> invoicesExpensesClassificationDetails
        {
            get
            {
                return _invoicesExpensesClassificationDetails;
            }
            set
            {
                _invoicesExpensesClassificationDetails = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die invoicesExpensesClassificationDetails-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the invoicesExpensesClassificationDetails collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool invoicesExpensesClassificationDetailsSpecified
        {
            get
            {
                return ((this.invoicesExpensesClassificationDetails != null) 
                            && (this.invoicesExpensesClassificationDetails.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="InvoiceExpensesClassificationType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="InvoiceExpensesClassificationType" /> class.</para>
        /// </summary>
        public InvoiceExpensesClassificationType()
        {
            this._invoicesExpensesClassificationDetails = new List<InvoicesExpensesClassificationDetailType>();
        }
        
        /// <summary>
        /// <para>Μέθοδος Υποβολής Χαρακτηρισμού</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// </summary>
        [DescriptionAttribute("Μέθοδος Υποβολής Χαρακτηρισμού")]
        [RangeAttribute(typeof(sbyte), "0", "1")]
        [XmlElementAttribute("classificationPostMode")]
        public sbyte classificationPostMode { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die classificationPostMode-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the classificationPostMode property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool classificationPostModeSpecified { get; set; }
    }
}
