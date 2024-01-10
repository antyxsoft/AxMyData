namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Κατηγορία ΦΠΑ
    /// <para>FOR: <see cref="ExpensesClassificationType.vatCategory"/> </para>
    /// <para>FOR: <see cref="InvoiceRowType.vatCategory"/> </para>
    /// <para>XSD Type: VatType</para>
    /// </summary>
    public class VatCategory
    {
        static List<VatCategory> fList;

        public VatCategory(int Value, string Percent, string Name)
        {
            this.Value = Value;
            this.Percent = Percent;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public int Value { get; }
        public string Percent { get; }
        public string Name { get; }

        static public List<VatCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<VatCategory>();

                    fList.Add(new VatCategory(1, "24", "ΦΠΑ συντελεστής 24%"));
                    fList.Add(new VatCategory(2, "13", "ΦΠΑ συντελεστής 13%"));
                    fList.Add(new VatCategory(3, "6", "ΦΠΑ συντελεστής 6%"));
                    fList.Add(new VatCategory(4, "17", "ΦΠΑ συντελεστής 17%"));
                    fList.Add(new VatCategory(5, "9", "ΦΠΑ συντελεστής 9%"));
                    fList.Add(new VatCategory(6, "4", "ΦΠΑ συντελεστής 4%"));
                    fList.Add(new VatCategory(7, "0", "Άνευ Φ.Π.Α."));
                    fList.Add(new VatCategory(8, null, "Εγγραφές χωρίς ΦΠΑ (πχ Μισθοδοσία, Αποσβέσεις)"));
                    fList.Add(new VatCategory(9, "3", "ΦΠΑ συντελεστής 3%"));
  
                }

                return fList;
            }
        }

        static public bool IsZeroFPA(int Value)
        {
            return Value == 7;
        }
        static public bool IsNoFPA(int Value)
        {
            return Value == 8;
        }
    }
}
