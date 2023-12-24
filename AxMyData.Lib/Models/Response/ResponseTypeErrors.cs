namespace AxMyData.Models.Response
{
    [XmlType(AnonymousType = true)]
    [Serializable]
    public partial class ResponseTypeErrors
    {
        [XmlElement("error")]
        public ErrorType[] error { get; set; }
    }
}
