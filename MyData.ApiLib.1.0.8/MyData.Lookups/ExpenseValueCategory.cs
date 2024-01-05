namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Κωδικός Τύπου Χαρακτηρισμού Εσόδων
    /// <para>FOR: <see cref="ExpensesClassificationType.classificationType"/> property </para>
    /// <para>XSD Type: ExpensesClassificationValueType </para>
    /// <para>NOTE: helper for AADE <see cref="ExpensesClassificationValueType"/> enum </para>
    /// </summary>
    public class ExpenseValueCategory
    {
        static List<ExpenseValueCategory> fList;

        public ExpenseValueCategory(ExpensesClassificationValueType Value, string Name)
        {
            this.Value = Value;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public ExpensesClassificationValueType Value { get; }
        public string Name { get; }

        public static List<ExpenseValueCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<ExpenseValueCategory>();
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_101, "Εμπορεύματα έναρξης"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_102_001   , "Αγορές εμπορευμάτων χρήσης (καθαρό ποσό)/Χονδρικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_102_002   , "Αγορές εμπορευμάτων χρήσης (καθαρό ποσό)/Λιανικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_102_003   , "Αγορές εμπορευμάτων χρήσης (καθαρό ποσό)/Αγαθών του άρθρου 39α παρ.5 του Κώδικα Φ.Π.Α. (ν.2859/2000)"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_102_004   , "Αγορές εμπορευμάτων χρήσης (καθαρό ποσό)/Εξωτερικού Ενδοκοινοτικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_102_005   , "Αγορές εμπορευμάτων χρήσης (καθαρό ποσό)/Εξωτερικού Τρίτες Χώρες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_102_006   , "Αγορές εμπορευμάτων χρήσης (καθαρό ποσό)Λοιπά"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_104       , "Εμπορεύματα λήξης"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_201       , "Πρώτες ύλες και υλικά έναρξης/Παραγωγή"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_202_001   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Χονδρικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_202_002   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Λιανικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_202_003   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Εξωτερικού Ενδοκοινοτικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_202_004   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Εξωτερικού Τρίτες Χώρες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_202_005   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Λοιπά"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_204       , "Αποθέματα λήξης πρώτων υλών και υλικών/Παραγωγή"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_207       , "Προϊόντα και παραγωγή σε εξέλιξη έναρξης/Παραγωγή"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_209       , "Προϊόντα και παραγωγή σε εξέλιξη λήξης/Παραγωγή"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_301       , "Πρώτες ύλες και υλικά έναρξης/Αγροτική"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_302_001   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Χονδρικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_302_002   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Λιανικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_302_003   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Εξωτερικού Ενδοκοινοτικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_302_004   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Εξωτερικού Τρίτες Χώρες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_302_005   , "Αγορές πρώτων υλών και υλικών χρήσης (καθαρό ποσό)/Λοιπά"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_304       , "Αποθέματα λήξης πρώτων υλών και υλικών/Αγροτική"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_307       , "Προϊόντα και παραγωγή σε εξέλιξη έναρξης/Αγροτική"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_309       , "Προϊόντα και παραγωγή σε εξέλιξη λήξης/Αγροτική"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_312       , "Αποθέματα έναρξης (ζώων - φυτών)"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_313_001   , "Αγορές ζώων - φυτών (καθαρό ποσό)/Χονδρικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_313_002   , "Αγορές ζώων - φυτών (καθαρό ποσό)/Λιανικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_313_003   , "Αγορές ζώων - φυτών (καθαρό ποσό)/Εξωτερικού Ενδοκοινοτικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_313_004   , "Αγορές ζώων - φυτών (καθαρό ποσό)/Εξωτερικού Τρίτες Χώρες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_313_005   , "Αγορές ζώων - φυτών (καθαρό ποσό)/Λοιπά"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_315       , "Αποθέματα τέλους (ζώων - φυτών)/Αγροτική"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_581_001   , "Παροχές σε εργαζόμενους/Μικτές αποδοχές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_581_002   , "Παροχές σε εργαζόμενους/Εργοδοτικές εισφορές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_581_003   , "Παροχές σε εργαζόμενους/Λοιπές παροχές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_582       , "Ζημιές επιμέτρησης περιουσιακών στοιχείων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_583       , "Χρεωστικές συναλλαγματικές διαφορές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_584       , "Ζημιές από διάθεση-απόσυρση μη κυκλοφορούντων περιουσιακών στοιχείων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_001   , "Προμήθειες διαχείρισης ημεδαπής - αλλοδαπής (management fees)"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_002   , "Δαπάνες από συνδεδεμένες επιχειρήσεις"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_003   , "Δαπάνες από μη συνεργαζόμενα κράτη ή από κράτη με προνομιακό φορολογικό καθεστώς"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_004   , "Δαπάνες για ενημερωτικές ημερίδες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_005   , "Έξοδα υποδοχής και φιλοξενίας"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_006   , "Έξοδα ταξιδιών"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_007   , "Ασφαλιστικές Εισφορές Αυτοαπασχολούμενων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_008   , "Έξοδα και προμήθειες παραγγελιοδόχου για λογαριασμό αγροτών"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_009   , "Λοιπές Αμοιβές για υπηρεσίες ημεδαπής"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_010   , "Λοιπές Αμοιβές για υπηρεσίες αλλοδαπής"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_011   , "Ενέργεια"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_012   , "Ύδρευση"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_013   , "Τηλεπικοινωνίες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_014   , "Ενοίκια"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_015   , "Διαφήμιση και προβολή"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_016   , "Λοιπά έξοδα"));
                    //fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_585_017   , "Διάφορα λειτουργικά έξοδα Ζ2"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_586       , "Χρεωστικοί τόκοι και συναφή έξοδα"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_587       , "Αποσβέσεις"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_588       , "Ασυνήθη έξοδα, ζημιές και πρόστιμα"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_589       , "Προβλέψεις (εκτός από προβλέψεις για το προσωπικό)"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_882_001   , "Αγορές ενσώματων παγίων χρήσης/Χονδρικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_882_002   , "Αγορές ενσώματων παγίων χρήσης/Λιανικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_882_003   , "Αγορές ενσώματων παγίων χρήσης/Εξωτερικού Ενδοκοινοτικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_882_004   , "Αγορές ενσώματων παγίων χρήσης/Εξωτερικού Τρίτες Χώρες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_883_001   , "Αγορές μη ενσώματων παγίων χρήσης/Χονδρικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_883_002   , "Αγορές μη ενσώματων παγίων χρήσης/Λιανικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_883_003   , "Αγορές μη ενσώματων παγίων χρήσης/Εξωτερικού Ενδοκοινοτικές"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_883_004   , "Αγορές μη ενσώματων παγίων χρήσης/Εξωτερικού Τρίτες Χώρες"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.VAT_361      , "Αγορές & δαπάνες στο εσωτερικό της χώρας"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.VAT_362      , "Αγορές & εισαγωγές επενδ. Αγαθών (πάγια)"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.VAT_363      , "Λοιπές εισαγωγές εκτός επενδ. Αγαθών (πάγια)"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.VAT_364      , "Ενδοκοινοτικές αποκτήσεις αγαθών"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.VAT_365      , "Ενδοκοινοτικές λήψεις υπηρεσιών άρθρ. 14.2.α"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.VAT_366      , "Λοιπές πράξεις λήπτη"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_103       , "Απομείωση εμπορευμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_203       , "Απομείωση πρώτων υλών και υλικών"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_303       , "Απομείωση πρώτων υλών και υλικών"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_208       , "Απομείωση προϊόντων και παραγωγής σε εξέλιξη"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_308       , "Απομείωση προϊόντων και παραγωγής σε εξέλιξη"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_314       , "Απομείωση ζώων - φυτών – εμπορευμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_106       , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_205       , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_305       , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_210       , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_310       , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_318       , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων"));
                    fList.Add(new ExpenseValueCategory(ExpensesClassificationValueType.E3_598_002   , "Αγορές αγαθών που υπάγονται σε ΕΦΚ"));
 

                }

                return fList;
            }
        }
    }
}
