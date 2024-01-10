namespace MyData.ApiLib 
{


    /// <summary>
    /// Είδος Φόρου
    /// <para>FOR: <see cref="TaxTotalsType.taxType"/> </para>
    /// <para>XSD Type: xs:byte</para>
    /// </summary>
    public class TaxType
    {
        static List<TaxType> fList;

        public TaxType(int Value, string Name)
        {
            this.Value = Value;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public int Value { get; }
        public string Name { get; }

        static public List<TaxType> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<TaxType>();

                    fList.Add(new TaxType(1, "Παρακρατούμενος Φόρος"));
                    fList.Add(new TaxType(2, "Τέλη"));
                    fList.Add(new TaxType(3, "Λοιποί Φόροι"));
                    fList.Add(new TaxType(4, "Χαρτόσημο"));
                    fList.Add(new TaxType(5, "Κρατήσεις")); 
                }

                return fList;
            }
        }

 
    }
}
