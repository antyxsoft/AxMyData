namespace AxMyData.Models.Response
{
    [Serializable]
    public partial class ProviderInfoType
    {
        /// <summary>
        /// ΑΦΜ
        /// </summary>
        [XmlElement("VATNumber")]
        public List<string> VATNumber { get; set; } = new List<string>();
    }
}
