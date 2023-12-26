namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Κωδικός Κατηγορίας Χαρακτηρισμού Εσόδων
    /// <para>FOR: <see cref="IncomeClassificationType.classificationCategory"/> property </para>
    /// <para>XSD Type: IncomeClassificationCategoryType </para>
    /// <para>NOTE: helper for AADE <see cref="IncomeClassificationCategoryType"/> enum </para>
    /// </summary>
    public class IncomeCategory
    {
        static List<IncomeCategory> fList;

        public IncomeCategory(IncomeClassificationCategoryType Value, string Name)
        {
            this.Value = Value;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public IncomeClassificationCategoryType Value { get; }
        public string Name { get; }

        public static List<IncomeCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<IncomeCategory>();

                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_1, "Έσοδα από Πώληση Εμπορευμάτων (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_2 , "Έσοδα από Πώληση Προϊόντων (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_3 , "Έσοδα από Παροχή Υπηρεσιών (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_4 , "Έσοδα από Πώληση Παγίων (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_5 , "Λοιπά Έσοδα/ Κέρδη (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_6 , "Αυτοπαραδόσεις / Ιδιοχρησιμοποιήσεις (+) / (-)"));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_7 , "Έσοδα για λ/σμο τρίτων (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_8 , "Έσοδα προηγούμενων χρήσεων (+)/ (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_9 , "Έσοδα επομένων χρήσεων (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_10, "Λοιπές Εγγραφές Τακτοποίησης Εσόδων (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category1_95, "Λοιπά Πληροφοριακά Στοιχεία Εσόδων (+) / (-) "));
                    fList.Add(new IncomeCategory(IncomeClassificationCategoryType.category3   , "Διακίνηση"));

                }

                return fList;
            }
        }
    }
}
