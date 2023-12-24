 

namespace AxMyData.Models
{
    
    [Serializable]
    [XmlType(Namespace = NS.PaymentMethod_v1)]
    public partial class PaymentMethodType
    {
        /// <summary>
        /// Μοναδικός Αριθμός Καταχώρησης Παραστατικού
        /// </summary>
        public long invoiceMark { get; set; }
        /// <summary>
        /// Αποδεικτικό Λήψης Τρόπων Πληρωμής. Συμπληρώνεται από την Υπηρεσία
        /// </summary>
        public long paymentMethodMark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool paymentMethodMarkSpecified { get; set; }
        /// <summary>
        /// ΑΦΜ Οντότητας Αναφοράς
        /// </summary>
        public string entityVatNumber { get; set; }
        /// <summary>
        /// paymentMethodDetails
        /// </summary>
        [XmlElement("paymentMethodDetails")]
        public List<PaymentMethodDetailType> paymentMethodDetails { get; set; } = new List<PaymentMethodDetailType>();
    }
}
