
namespace AxMyData.Models
{
 
    [Serializable] 
    [XmlType(AnonymousType = true, Namespace = NS.Income_v1)]
    [XmlRoot(Namespace = NS.Income_v1, IsNullable = false)]
    public partial class IncomeClassificationsDoc
    {

        [XmlElement("incomeInvoiceClassification")]
        public List<InvoiceIncomeClassificationType> incomeInvoiceClassification { get; set; } = new List<InvoiceIncomeClassificationType>();
    }
}
