namespace AxMyData.Models.Response
{
    [Serializable]
    public partial class receptionEmailsType
    {
        [XmlElement("email")]
        public List<string> email { get; set; } = new List<string>();
    }
}
