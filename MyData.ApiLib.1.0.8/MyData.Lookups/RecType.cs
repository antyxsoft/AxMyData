namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Είδος Γραμμής
    /// <para>FOR: <see cref="InvoiceRowType.recType"/> property </para>
    /// <para>XSD Type: no type</para>
    /// </summary>
    public class RecType
    {
        static List<RecType> fList;

        public RecType(int Value, string Name)
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

        public static List<RecType> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<RecType>();

                    fList.Add(new RecType(1, "Ειδική Γραμμή Παρακρατούμενων Φόρων"));
                    fList.Add(new RecType(2, "Γραμμή Τέλους με Φ.Π.Α."));
                    fList.Add(new RecType(3, "Γραμμή Λοιπών Φόρων με Φ.Π.Α."));
                    fList.Add(new RecType(4, "Ειδική Γραμμή Χαρτοσήμου"));
                    fList.Add(new RecType(5, "Ειδική Γραμμή Κρατήσεων"));
                    fList.Add(new RecType(6, "Δωροεπιταγή"));
                    fList.Add(new RecType(7, "Αρνητικό πρόσημο αξιών"));
                }

                return fList;
            }
        }
    }
}
