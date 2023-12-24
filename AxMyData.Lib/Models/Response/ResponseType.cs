namespace AxMyData.Models.Response
{
    /// <summary>
    /// 6.1 Υποβολή Δεδομένων
    /// </summary>
    [Serializable]
    public partial class ResponseType
    {

        /// <summary>
        /// ΑΑ γραμμής οντότητας
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// indexSpecified
        /// </summary>
        [XmlIgnore]
        public bool indexSpecified { get; set; }
        /// <summary>
        /// The XmlElementAttribute can be applied multiple times to a field that returns an array of objects. 
        /// The purpose of this is to specify (through the Type property) different types that can be inserted into the array. 
        /// <para>
        /// Σε περίπτωση επιτυχίας το πεδίο statusCode έχει τιμή Success και η απάντηση περιλαμβάνει τις αντίστοιχες τιμές 
        /// για τα πεδία entityUid και entityMark για κάθε οντότητα που υποβλήθηκε. 
        /// (σσ. Προφανώς κάθε element του Items θα είναι ένα object με δύο properties: entityUid και entityMark)
        /// </para>
        /// <para>
        /// Σε περίπτωση αποτυχίας το πεδίο statusCode έχει τιμή αντίστοιχη του είδους του σφάλματος 
        /// και η απάντηση περιλαμβάνει μια λίστα στοιχείων σφάλματος τύπου ErrorType 
        /// για κάθε οντότητα που η υποβολή της απέτυχε.
        /// Όλα τα στοιχεία σφάλματος ανά οντότητα είναι υποχρεωτικά της ίδιας κατηγορίας που χαρακτηρίζει την απάντηση
        /// </para>
        /// </summary>
        [XmlElement("authenticationCode", typeof(string))]
        [XmlElement("cancellationMark", typeof(long))]
        [XmlElement("classificationMark", typeof(long))]
        [XmlElement("errors", typeof(ResponseTypeErrors))]
        [XmlElement("invoiceMark", typeof(long))]
        [XmlElement("invoiceUid", typeof(string))]
        [XmlElement("paymentMethodMark", typeof(long))]
        [XmlElement("qrUrl", typeof(string))]
        [XmlElement("receptionEmails", typeof(receptionEmailsType))]
        [XmlElement("receptionProviders", typeof(receptionProvidersType))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public List<object> Items { get; set; } = new List<object>();

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public List<ItemsChoiceType> ItemsElementName { get; set; } = new List<ItemsChoiceType>();

        /// <summary>
        /// Κωδικός Αποτελέσματος
        /// <para>Required.</para>
        /// <para>Τιμές:</para>
        /// <para>
        /// Success,
        /// ValidationError,
        /// TechnicalError,
        /// XMLSyntaxError
        /// </para>
        /// </summary>
        public string statusCode { get; set; }

    }
}
