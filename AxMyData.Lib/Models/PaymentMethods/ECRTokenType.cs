
namespace AxMyData.Models
{
    [Serializable]
    [XmlType(Namespace = NS.Invoice_v1)]
    public partial class ECRTokenType
    {
        public string SigningAuthor { get; set; }
        public string SessionNumber { get; set; }
    }
}
