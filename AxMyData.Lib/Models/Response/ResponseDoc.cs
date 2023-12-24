namespace AxMyData.Models.Response
{
    /// <summary>
    /// 6.1 Υποβολή Δεδομένων
    /// <para>Στις περιπτώσεις που ο χρήστης χρησιμοποιήσει κάποιο service υποβολής οντότητας 
    /// (sendInvoice, sendIncomeClassification, sendExpensesClassification) 
    /// θα λαμβάνει ως απάντηση από την διεπαφή ένα αντικείμενο ResponseDoc σε xml μορφή. 
    /// Το αντικείμενο περιλαμβάνει μια λίστα από στοιχεία τύπου response, ένα για κάθε οντότητα που υποβλήθηκε.
    /// </para>
    /// </summary>
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ResponseDoc
    {
        [XmlElement("response")]
        public List<ResponseType> response { get; set; } = new List<ResponseType>();
    }
}
