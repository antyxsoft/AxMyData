namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Τύπος Απόκλισης Παραστατικού 
    /// <para>FOR: <see cref="InvoiceHeaderType.invoiceVariationType"/> property </para>
    /// <para>XSD Type: InvoiceVariationType</para>
    /// </summary>
    public class InvoiceVariationType
    {
        static List<InvoiceVariationType> fList;

        public InvoiceVariationType(int Value, string Name)
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

        public static List<InvoiceVariationType> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<InvoiceVariationType>();

                    fList.Add(new InvoiceVariationType(1, "Διαβίβαση Παράλειψης από Λήπτη"));
                    fList.Add(new InvoiceVariationType(2, "Διαβίβαση Παράλειψης από Εκδότη"));
                    fList.Add(new InvoiceVariationType(3, "Διαβίβαση Απόκλισης από Λήπτη"));
                    fList.Add(new InvoiceVariationType(4, "Διαβίβαση Απόκλισης από Εκδότη"));

                }

                return fList;
            }
        }
    }
}
