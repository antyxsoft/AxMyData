
namespace AxMyData.Models
{
 
    [Serializable]
    [XmlType(Namespace = NS.Income_v1)]
    public partial class IncomeClassificationType
    {
        /// <summary>
        /// Κωδικός Χαρακτηρισμού
        /// </summary>
        public IncomeClassificationValueType classificationType {  get; set; }
        [XmlIgnore]
        public bool classificationTypeSpecified { get; set; }
        /// <summary>
        /// Κατηγορία Χαρακτηρισμού
        /// </summary>
        public IncomeClassificationCategoryType classificationCategory { get; set; }
        /// <summary>
        /// Ποσό Χαρακτηρισμού
        /// </summary>
        public decimal amount { get; set; }
        /// <summary>
        /// Μοναδικός Αριθμός Χαρακτηρισμού
        /// </summary>
        public sbyte id { get; set; }
        [XmlIgnore]
        public bool idSpecified { get; set; }
    }
}
