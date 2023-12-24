namespace AxMyData.Models.Response
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        /// <summary>
        /// Συμβολοσειρά Αυθεντικοποίησης Παρόχου
        /// </summary>
        authenticationCode,
        /// <summary>
        /// Μοναδικός Αριθμός Ακύρωσης
        /// </summary>
        cancellationMark,
        /// <summary>
        /// Μοναδικός Αριθμός Παραλαβής Χαρακτηρισμού
        /// </summary>
        classificationMark,
        /// <summary>
        /// Λίστα Σφαλμάτων
        /// </summary>
        errors,
        /// <summary>
        /// Μοναδικός Αριθμός Καταχώρησης παραστατικού
        /// </summary>
        invoiceMark,
        /// <summary>
        /// Αναγνωριστικό οντότητας
        /// </summary>
        invoiceUid,
        /// <summary>
        /// Μοναδικός Αριθμός Παραλαβής Τρόπου Πληρωμής
        /// </summary>
        paymentMethodMark,
        /// <summary>
        /// QR Code Url
        /// </summary>
        qrUrl,
        /// <summary>
        /// Email Παραλαβής
        /// </summary>
        receptionEmails,
        /// <summary>
        /// Πάροχοι Λήπτη
        /// </summary>
        receptionProviders,
    }
}
