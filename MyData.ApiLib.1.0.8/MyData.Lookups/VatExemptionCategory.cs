namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Κατηγορία Αιτίας Εξαίρεσης ΦΠΑ
    /// <para>FOR: <see cref="ExpensesClassificationType.vatExemptionCategory"/> property </para>
    /// <para>FOR: <see cref="InvoiceRowType.vatExemptionCategory"/> property </para>
    /// <para>XSD Type: VatExemptionType</para>
    /// </summary>
    public class VatExemptionCategory
    {
        static List<VatExemptionCategory> fList;

        public VatExemptionCategory(int Value, string Name)
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

        static public List<VatExemptionCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<VatExemptionCategory>();
                    fList.Add(new VatExemptionCategory(1, "Χωρίς ΦΠΑ - άρθρο 3 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(2, "Χωρίς ΦΠΑ - άρθρο 5 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(3, "Χωρίς ΦΠΑ - άρθρο 13 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(4, "Χωρίς ΦΠΑ - άρθρο 14 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(5, "Χωρίς ΦΠΑ - άρθρο 16 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(6, "Χωρίς ΦΠΑ - άρθρο 19 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(7, "Χωρίς ΦΠΑ - άρθρο 22 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(8, "Χωρίς ΦΠΑ - άρθρο 24 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(9, "Χωρίς ΦΠΑ - άρθρο 25 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(10, "Χωρίς ΦΠΑ - άρθρο 26 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(11, "Χωρίς ΦΠΑ - άρθρο 27 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(12, "Χωρίς ΦΠΑ - άρθρο 27 - Πλοία Ανοικτής Θαλάσσης του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(13, "Χωρίς ΦΠΑ - άρθρο 27.1.γ - Πλοία Ανοικτής Θαλάσσης του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(14, "Χωρίς ΦΠΑ - άρθρο 28 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(15, "Χωρίς ΦΠΑ - άρθρο 39 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(16, "Χωρίς ΦΠΑ - άρθρο 39α του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(17, "Χωρίς ΦΠΑ - άρθρο 40 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(18, "Χωρίς ΦΠΑ - άρθρο 41 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(19, "Χωρίς ΦΠΑ - άρθρο 47 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(20, "ΦΠΑ εμπεριεχόμενος - άρθρο 43 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(21, "ΦΠΑ εμπεριεχόμενος - άρθρο 44 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(22, "ΦΠΑ εμπεριεχόμενος - άρθρο 45 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(23, "ΦΠΑ εμπεριεχόμενος - άρθρο 46 του Κώδικα ΦΠΑ"));

                    fList.Add(new VatExemptionCategory(24, "Χωρίς ΦΠΑ - άρθρο 6 του Κώδικα ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(25, "Χωρίς ΦΠΑ - ΠΟΛ.1029/1995"));
                    fList.Add(new VatExemptionCategory(26, "Χωρίς ΦΠΑ - ΠΟΛ.1167/2015"));
                    fList.Add(new VatExemptionCategory(27, "Λοιπές Εξαιρέσεις ΦΠΑ"));
                    fList.Add(new VatExemptionCategory(28, "Χωρίς ΦΠΑ – άρθρο 24 περ. β' παρ.1 του Κώδικα ΦΠΑ, (Tax Free)"));
                    fList.Add(new VatExemptionCategory(29, "Χωρίς ΦΠΑ – άρθρο 47β, του Κώδικα ΦΠΑ (OSS μη ενωσιακό καθεστώς)"));
                    fList.Add(new VatExemptionCategory(30, "Χωρίς ΦΠΑ – άρθρο 47γ, του Κώδικα ΦΠΑ (OSS ενωσιακό καθεστώς)"));
                    fList.Add(new VatExemptionCategory(31, "Χωρίς ΦΠΑ – άρθρο 47δ του Κώδικα ΦΠΑ (IOSS)"));
 
                }

                return fList;
            }
        }
    }
}
