 

namespace AxMyData.Models
{
    [Serializable] 
    [XmlType(Namespace = NS.Income_v1)]
    public partial class InvoicesIncomeClassificationDetailType
    {
        /// <summary>
        /// Αριθμός Γραμμής.
        /// <para>Το πεδίο lineNumber αναφέρεται στον αντίστοιχο αριθμό γραμμής του αρχικού παραστατικού με Μοναδικός Αριθμός Καταχώρησης αυτό του πεδίου mark</para>
        /// <para>Required.</para>
        /// </summary>
        public int lineNumber { get; set; }
        /// <summary>
        /// Λίστα Χαρακτηρισμών Εσόδων
        /// </summary>
        [XmlElement("incomeClassificationDetailData")]
        public List<IncomeClassificationType> incomeClassificationDetailData { get; set; } = new List<IncomeClassificationType>();
    }
}
