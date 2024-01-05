namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Είδος Ποσότητας
    /// <para>FOR: <see cref="InvoiceRowType.measurementUnit"/> property </para>
    /// <para>XSD Type: QuantityType</para>
    /// </summary>
    public class MeasUnit
    {
        static List<MeasUnit> fList;

        public MeasUnit(int Value, string Name)
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

        public static List<MeasUnit> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<MeasUnit>();

                    fList.Add(new MeasUnit(1, "Τεμάχια "));
                    fList.Add(new MeasUnit(2, "Κιλά "));
                    fList.Add(new MeasUnit(3, "Λίτρα "));
                    fList.Add(new MeasUnit(4, "Μέτρα "));
                    fList.Add(new MeasUnit(5, "Τετραγωνικά Μέτρα "));
                    fList.Add(new MeasUnit(6, "Κυβικά Μέτρα "));
                    fList.Add(new MeasUnit(7, "Τεμάχια_Λοιπές Περιπτώσεις"));

                }
 
                return fList;
            }
        }
    }
}
