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
    [XmlTypeAttribute("AadeBookInvoiceType", Namespace="http://www.aade.gr/myDATA/invoice/v1.0")]
    public partial class AadeBookInvoiceType
    {
        
        /// <summary>
        /// <para>Αναγνωριστικό Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Αναγνωριστικό Παραστατικού")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("uid")]
        public string uid { get; set; }
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Καταχώρησης Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Μοναδικός Αριθμός Καταχώρησης Παραστατικού")]
        [XmlElementAttribute("mark")]
        public long mark { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die mark-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the mark property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool markSpecified { get; set; }
        
        /// <summary>
        /// <para>Μοναδικός Αριθμός Καταχώρησης Ακυρωτικού</para>
        /// </summary>
        [DescriptionAttribute("Μοναδικός Αριθμός Καταχώρησης Ακυρωτικού")]
        [XmlElementAttribute("cancelledByMark")]
        public long cancelledByMark { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die cancelledByMark-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the cancelledByMark property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool cancelledByMarkSpecified { get; set; }
        
        /// <summary>
        /// <para>Συμβολοσειρά Αυθεντικοποίησης Παρόχου</para>
        /// </summary>
        [DescriptionAttribute("Συμβολοσειρά Αυθεντικοποίησης Παρόχου")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("authenticationCode")]
        public string authenticationCode { get; set; }
        
        /// <summary>
        /// <para>Αδυναμία Επικοινωνίας Παρόχου ή Αδυναμία διαβίβασης ERP</para>
        /// <para xml:lang="en">Minimum inclusive value: 1.</para>
        /// <para xml:lang="en">Maximum inclusive value: 3.</para>
        /// </summary>
        [DescriptionAttribute("Αδυναμία Επικοινωνίας Παρόχου ή Αδυναμία διαβίβασης ERP")]
        [RangeAttribute(typeof(sbyte), "1", "3")]
        [XmlElementAttribute("transmissionFailure")]
        public sbyte transmissionFailure { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die transmissionFailure-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the transmissionFailure property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool transmissionFailureSpecified { get; set; }
        
        /// <summary>
        /// <para>Στοιχεία Εκδότη</para>
        /// </summary>
        [DescriptionAttribute("Στοιχεία Εκδότη")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("issuer")]
        public PartyType issuer { get; set; }
        
        /// <summary>
        /// <para>Στοιχεία Λήπτη</para>
        /// </summary>
        [DescriptionAttribute("Στοιχεία Λήπτη")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("counterpart")]
        public PartyType counterpart { get; set; }
        
        /// <summary>
        /// <para>Γενικά Στοιχεία</para>
        /// </summary>
        [DescriptionAttribute("Γενικά Στοιχεία")]
        [RequiredAttribute()]
        [XmlElementAttribute("invoiceHeader")]
        public InvoiceHeaderType invoiceHeader { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PaymentMethodDetailType> _paymentMethods;
        
        /// <summary>
        /// <para>Πληρωμές</para>
        /// </summary>
        [DescriptionAttribute("Πληρωμές")]
        [XmlArrayAttribute("paymentMethods")]
        [XmlArrayItemAttribute("paymentMethodDetails", Namespace="http://www.aade.gr/myDATA/invoice/v1.0")]
        public List<PaymentMethodDetailType> paymentMethods
        {
            get
            {
                return _paymentMethods;
            }
            set
            {
                _paymentMethods = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die paymentMethods-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the paymentMethods collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool paymentMethodsSpecified
        {
            get
            {
                return ((this.paymentMethods != null) 
                            && (this.paymentMethods.Count != 0));
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AadeBookInvoiceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AadeBookInvoiceType" /> class.</para>
        /// </summary>
        public AadeBookInvoiceType()
        {
            this._paymentMethods = new List<PaymentMethodDetailType>();
            this._invoiceDetails = new List<InvoiceRowType>();
            this._taxesTotals = new List<TaxTotalsType>();
            this._otherTransportDetails = new List<TransportDetailType>();
        }
        
        [XmlIgnoreAttribute()]
        private List<InvoiceRowType> _invoiceDetails;
        
        /// <summary>
        /// <para>Λεπτομέρειες Παραστατικού</para>
        /// </summary>
        [DescriptionAttribute("Λεπτομέρειες Παραστατικού")]
        [RequiredAttribute()]
        [XmlElementAttribute("invoiceDetails")]
        public List<InvoiceRowType> invoiceDetails
        {
            get
            {
                return _invoiceDetails;
            }
            set
            {
                _invoiceDetails = value;
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TaxTotalsType> _taxesTotals;
        
        /// <summary>
        /// <para>Σύνολα Φόρων</para>
        /// </summary>
        [DescriptionAttribute("Σύνολα Φόρων")]
        [XmlArrayAttribute("taxesTotals")]
        [XmlArrayItemAttribute("taxes", Namespace="http://www.aade.gr/myDATA/invoice/v1.0")]
        public List<TaxTotalsType> taxesTotals
        {
            get
            {
                return _taxesTotals;
            }
            set
            {
                _taxesTotals = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die taxesTotals-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the taxesTotals collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool taxesTotalsSpecified
        {
            get
            {
                return ((this.taxesTotals != null) 
                            && (this.taxesTotals.Count != 0));
            }
        }
        
        /// <summary>
        /// <para>Συγκεντρωτικά Στοιχεία</para>
        /// </summary>
        [DescriptionAttribute("Συγκεντρωτικά Στοιχεία")]
        [RequiredAttribute()]
        [XmlElementAttribute("invoiceSummary")]
        public InvoiceSummaryType invoiceSummary { get; set; }
        
        /// <summary>
        /// <para>QR Code Url</para>
        /// </summary>
        [DescriptionAttribute("QR Code Url")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("qrCodeUrl")]
        public string qrCodeUrl { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportDetailType> _otherTransportDetails;
        
        /// <summary>
        /// <para>Λοιπές Λεπτομέρειες Διακίνησης (Ορισμός - Αλλαγή Μτφ Μέσων, Μεταφορτώσεις, κλπ)</para>
        /// </summary>
        [DescriptionAttribute("Λοιπές Λεπτομέρειες Διακίνησης (Ορισμός - Αλλαγή Μτφ Μέσων, Μεταφορτώσεις, κλπ)")]
        [XmlElementAttribute("otherTransportDetails")]
        public List<TransportDetailType> otherTransportDetails
        {
            get
            {
                return _otherTransportDetails;
            }
            set
            {
                _otherTransportDetails = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die otherTransportDetails-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the otherTransportDetails collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool otherTransportDetailsSpecified
        {
            get
            {
                return ((this.otherTransportDetails != null) 
                            && (this.otherTransportDetails.Count != 0));
            }
        }
    }
}