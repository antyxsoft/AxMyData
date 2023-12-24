 
namespace AxMyData.Models
{

    [Serializable]
    [XmlType(Namespace = NS.Invoice_v1)]
    public partial class ProviderSignatureType
    { 
        public string SigningAuthor { get; set; }
        public string Signature { get; set; }
    }

}
