
namespace AxMyData.Models
{

    /// <summary>
    /// To στοιχείο αυτό είναι μία ακολουθία από ένα ή περισσότερους χαρακτηρισμούς εσόδων
    /// </summary>
    [Serializable]
    [XmlType(Namespace = NS.Income_v1)]
    public partial class InvoiceIncomeClassificationType
    {

        /// <summary>
        /// Μοναδικός Αριθμός Καταχώρησης Παραστατικού
        /// </summary>        
        public long invoiceMark { get; set; }
        /// <summary>
        /// Αποδεικτικό Λήψης Χαρακτηρισμού Εσόδων. Συμπληρώνεται από την Υπηρεσία
        /// </summary>
        public long classificationMark { get; set; }
        [XmlIgnore]
        public bool classificationMarkSpecified { get; set; }
        /// <summary>
        /// ΑΦΜ Οντότητας Αναφοράς
        /// </summary>
        public string entityVatNumber { get; set; }
        /// <summary>
        /// Λίστα στοιχείων
        /// </summary>
        [XmlElement("invoicesIncomeClassificationDetails", typeof(InvoicesIncomeClassificationDetailType))]
        [XmlElement("transactionMode", typeof(int))]
        public List<object> Items { get; set; } = new List<object>();
    }



}

