namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Κατηγορία Συντελεστή Χαρτοσήμου
    /// <para>FOR: <see cref="InvoiceRowType.stampDutyPercentCategory"/> property </para>
    /// <para>XSD Type: StampDutyType</para>
    /// </summary>
    public class StampDutyCategory
    {
        static List<StampDutyCategory> fList;
 
        public StampDutyCategory(int Value, string Name, string Amount)
        {
            this.Value = Value;
            this.Name = Name.Trim();
            this.Amount = Amount;
        }

        public override string ToString()
        {
            return Name;
        }

        public int Value { get; }
        public string Name { get; }
        public string Amount { get; }

        static public StampDutyCategory[] List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<StampDutyCategory>();
                    fList.Add(new StampDutyCategory(1, "Συντελεστής 1,2 %				", "1,20%"));
                    fList.Add(new StampDutyCategory(2, "Συντελεστής 2,4 %				", "2,40%"));
                    fList.Add(new StampDutyCategory(3, "Συντελεστής 3,6 %				", "3,60%"));
                    fList.Add(new StampDutyCategory(4, "Λοιπές περιπτώσεις Χαρτοσήμου", "ποσό"));
                }

                return fList.ToArray();
            }
        }
    }
}
