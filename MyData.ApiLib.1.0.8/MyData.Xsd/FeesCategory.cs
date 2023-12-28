namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Κατηγορία Τελών
    /// <para>FOR: <see cref="InvoiceRowType.feesPercentCategory"/> property</para>
    /// <para>XSD Type: FeesType</para>
    /// </summary>
    public class FeesCategory
    {
        static List<FeesCategory> fList; 

        public FeesCategory(int Value, string Name, string Amount)
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

        public static List<FeesCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<FeesCategory>();
                    fList.Add(new FeesCategory( 1, "Για μηνιαίο λογαριασμό μέχρι και 50 ευρώ 12%															", "12,00%"));
                    fList.Add(new FeesCategory( 2, "Για μηνιαίο λογαριασμό από 50,01 μέχρι και 100 ευρώ 15%												", "15,00%"));
                    fList.Add(new FeesCategory( 3, "Για μηνιαίο λογαριασμό από 100,01 μέχρι και 150 ευρώ 18%												", "18,00%"));
                    fList.Add(new FeesCategory( 4, "Για μηνιαίο λογαριασμό από 150,01 ευρώ και άνω 20%													", "20,00%"));
                    fList.Add(new FeesCategory( 5, "Τέλος καρτοκινητής επί της αξίας του χρόνου ομιλίας (12%)											", "12,00%"));
                    fList.Add(new FeesCategory( 6, "Τέλος στη συνδρομητική τηλεόραση 10%																	", "10,00%"));
                    fList.Add(new FeesCategory( 7, "Τέλος συνδρομητών σταθερής τηλεφωνίας 5%																", "5,00%"));
                    fList.Add(new FeesCategory( 8, "Περιβαλλοντικό Τέλος & πλαστικής σακούλας ν. 2339/2001 αρ. 6α 0,07 ευρώ ανά τεμάχιο					", "ποσό"));
                    fList.Add(new FeesCategory( 9, "Εισφορά δακοκτονίας 2%																				", "2,00%"));
                    fList.Add(new FeesCategory(10, "Λοιπά τέλη																							", "ποσό"));
                    fList.Add(new FeesCategory(11, "Τέλη Λοιπών Φόρων																					", "Ποσό"));
                    fList.Add(new FeesCategory(12, "Εισφορά δακοκτονίας																					", "Ποσό"));
                    fList.Add(new FeesCategory(13, "Για μηνιαίο λογαριασμό κάθε σύνδεσης (10%)															", "10%"));
                    fList.Add(new FeesCategory(14, "Τέλος καρτοκινητής επί της αξίας του χρόνου ομιλίας (10%)											", "10%"));
                    fList.Add(new FeesCategory(15, "Τέλος κινητής και καρτοκινητής για φυσικά πρόσωπα ηλικίας 15 έως και 29 ετών (0%)					", "0%"));
                    fList.Add(new FeesCategory(16, "Εισφορά προστασίας περιβάλλοντος πλαστικών προϊόντων 0,04 λεπτά ανά τεμάχιο [άρθρο 4 ν. 4736/2020]	", "ποσό"));
                    fList.Add(new FeesCategory(17, "Τέλος ανακύκλωσης 0,08 λεπτά ανά τεμάχιο [άρθρο 80 ν. 4819/2021]										", "Ποσό"));
                    fList.Add(new FeesCategory(18, "Τέλος διαμονής παρεπιδημούντων																		", "Ποσό"));
                    fList.Add(new FeesCategory(19, "Τέλος επί των ακαθάριστων εσόδων των εστιατορίων και συναφών καταστημάτων							", "Ποσό"));
                    fList.Add(new FeesCategory(20, "Τέλος επί των ακαθάριστων εσόδων των κέντρων διασκέδασης												", "Ποσό"));
                    fList.Add(new FeesCategory(21, "Τέλος επί των ακαθάριστων εσόδων των καζίνο															", "Ποσό"));
                    fList.Add(new FeesCategory(22, "Λοιπά τέλη επί των ακαθάριστων εσόδων																", "Ποσό"));
              

                }

                return fList;
            }
        }
    }
}
