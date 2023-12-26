namespace MyData.Xsd
{
 
    /// <summary>
    /// Παράρτημα: Επισήμανση
    /// <para>FOR: <see cref="InvoiceRowType.invoiceDetailType"/> property </para>
    /// <para>XSD Type: no type</para>
    /// </summary>
    public class InvoiceDetailType
    {
        static List<InvoiceDetailType> fList;

        public InvoiceDetailType(int Value, string Name)
        {
            this.Value = Value;
            this.Name = Name.Trim();
        }


        public override string ToString()
        {
            return Name;
        }

        public int Value { get; }
        public string Name { get; }

        public static List<InvoiceDetailType> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<InvoiceDetailType>();

                    fList.Add(new InvoiceDetailType(1, "Εκκαθάριση Πωλήσεων Τρίτων"));
                    fList.Add(new InvoiceDetailType(2, "Αμοιβή από Πωλήσεις Τρίτων")); 
                }
 
                return fList;
            }
        }
    }
}
