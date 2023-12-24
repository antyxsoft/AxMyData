 
namespace AxMyData.Models
{

    /// <summary>
    /// Μέθοδοι Πληρωμής
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = NS.PaymentMethod_v1)]
    [XmlRoot(Namespace = NS.PaymentMethod_v1, IsNullable = false)]
    public partial class PaymentMethodsDoc
    {

        /// <remarks/>
        [XmlElement("paymentMethods")]
        public List<PaymentMethodType> paymentMethods { get; set; } = new List<PaymentMethodType>();
    }
}
