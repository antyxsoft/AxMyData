namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Κωδικός Κατηγορίας Χαρακτηρισμού Εξόδων
    /// <para>FOR: <see cref="ExpensesClassificationType.classificationCategory"/> property </para>
    /// <para>XSD Type: ExpensesClassificationCategoryType </para>
    /// <para>NOTE: helper for AADE <see cref="ExpensesClassificationCategoryType"/> enum </para>
    /// </summary>
    public class ExpenseCategory
    {
        static List<ExpenseCategory> fList;

        public ExpenseCategory(ExpensesClassificationCategoryType Value, string Name)
        {
            this.Value = Value;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public ExpensesClassificationCategoryType Value { get; }
        public string Name { get; }

        public static List<ExpenseCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<ExpenseCategory>();

                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_1, "Αγορές Εμπορευμάτων (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_2 , "Αγορές Α'-Β' Υλών (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_3 , "Λήψη Υπηρεσιών (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_4 , "Γενικά Έξοδα με δικαίωμα έκπτωσης ΦΠΑ (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_5 , "Γενικά Έξοδα χωρίς δικαίωμα έκπτωσης ΦΠΑ (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_6 , "Αμοιβές και Παροχές προσωπικού (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_7 , "Αγορές Παγίων (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_8 , "Αποσβέσεις Παγίων (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_9 , "Έξοδα για λ/σμο τρίτων (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_10, "Έξοδα προηγούμενων χρήσεων (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_11, "Έξοδα επομένων χρήσεων (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_12, "Λοιπές Εγγραφές Τακτοποίησης Εξόδων (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_13, "Αποθέματα Έναρξης Περιόδου (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_14, "Αποθέματα Λήξης Περιόδου (-) / (+)"));
                    fList.Add(new ExpenseCategory(ExpensesClassificationCategoryType.category2_95, "Λοιπά Πληροφοριακά Στοιχεία Εξόδων (-) / (+)"));
                }

                return fList;
            }
        }
    }
}
