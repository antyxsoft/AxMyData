namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Ειδική Κατηγορία Παραστατικού
    /// <para>FOR: <see cref="InvoiceHeaderType.specialInvoiceCategory"/> property </para>
    /// <para>XSD Type: SpecialInvoiceCategoryType</para>
    /// </summary>
    public class SpecialInvoiceCategory
    {
        static List<SpecialInvoiceCategory> fList;

        public SpecialInvoiceCategory(int Value, string Name)
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

        public static List<SpecialInvoiceCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<SpecialInvoiceCategory>();

                    fList.Add(new SpecialInvoiceCategory(1, "Επιδοτήσεις – Επιχορηγήσεις"));
                    fList.Add(new SpecialInvoiceCategory(2 , "Έσοδα Λιανικής Ξενοδοχείων – Χρεώσεις Δωματίου"));
                    fList.Add(new SpecialInvoiceCategory(3 , "Λογιστική Εγγραφή"));
                    fList.Add(new SpecialInvoiceCategory(4 , "Tax Free"));
                    fList.Add(new SpecialInvoiceCategory(5 , "Σύνθετες συναλλαγές ημεδαπής – αλλοδαπής"));
                    fList.Add(new SpecialInvoiceCategory(6 , "Δικαιούχοι του άρθρου 3 της υπό στοιχεία 139818 ΕΞ2022/28.09.2022 (Β’5083) κοινής υπουργικής απόφασης"));
                    fList.Add(new SpecialInvoiceCategory(7 , "Αγορά αγροτικών αγαθών υπηρεσιών Άρθρο 41 του Κώδικα ΦΠΑ"));
                    fList.Add(new SpecialInvoiceCategory(8 , "Έσοδα Λιανικών ΦΗΜ ΑΑΔΕ_1"));
                    fList.Add(new SpecialInvoiceCategory(9 , "Έσοδα Λιανικών ΦΗΜ ΑΑΔΕ_2"));
                    fList.Add(new SpecialInvoiceCategory(10, "Έσοδα Λιανικών ΦΗΜ Επιχείρησης Απόκλιση"));
                    fList.Add(new SpecialInvoiceCategory(11, "Επίδομα Θέρμανσης"));
                    fList.Add(new SpecialInvoiceCategory(12, "Συναλλαγές εστίασης"));
  


                }

                return fList;
            }
        }
    }
}
