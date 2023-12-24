

namespace AxMyData.Models
{
    [Serializable]
    [XmlType(Namespace = NS.Invoice_v1)]
    public partial class PaymentMethodDetailType
    {        
        public int type { get; set; }
        public decimal amount { get; set; }
        public string paymentMethodInfo { get; set; }
        public decimal tipAmount { get; set; }
        [XmlIgnore]
        public bool tipAmountSpecified { get; set; }
        public string transactionId { get; set; }
        public ProviderSignatureType ProvidersSignature { get; set; }
        public ECRTokenType ECRToken { get; set; }
    }
}
