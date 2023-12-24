namespace AxMyData.Models.Response
{
    [Serializable]
    public partial class receptionProvidersType
    {
        [XmlElement("ProviderInfo")]
        public ProviderInfoType[] ProviderInfo;
    }
}
