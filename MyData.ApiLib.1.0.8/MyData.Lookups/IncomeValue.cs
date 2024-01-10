namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Κωδικός Τύπου Χαρακτηρισμού Εσόδων
    /// <para>FOR: <see cref="IncomeClassificationType.classificationType"/></para>
    /// <para>XSD Type: IncomeClassificationValueType </para>
    /// <para>NOTE: helper for AADE <see cref="IncomeClassificationValueType"/> enum </para>
    /// </summary>
    public class IncomeValue
    {
        static List<IncomeValue> fList;

        public IncomeValue(IncomeClassificationValueType Value, string Name)
        {
            this.Value = Value;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public IncomeClassificationValueType Value { get; }
        public string Name { get; }

        public static List<IncomeValue> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<IncomeValue>();
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_106, "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων/Εμπορεύματα "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_205    , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων/Πρώτες ύλες και λοιπά υλικά "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_210    , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων/Προϊόντα και παραγωγή σε εξέλιξη "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_305    , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις – Καταστροφές αποθεμάτων/Πρώτες ύλες και λοιπά υλικά "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_310    , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων/Προϊόντα και παραγωγή σε εξέλιξη "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_318    , "Ιδιοπαραγωγή παγίων - Αυτοπαραδόσεις - Καταστροφές αποθεμάτων/Έξοδα παραγωγής "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_561_001, "Πωλήσεις αγαθών και υπηρεσιών Χονδρικές - Επιτηδευματιών "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_561_002, "Πωλήσεις αγαθών και υπηρεσιών Χονδρικές βάσει άρθρου 39α παρ 5 του Κώδικα Φ.Π.Α. (Ν.2859/2000) "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_561_003, "Πωλήσεις αγαθών και υπηρεσιών Λιανικές - Ιδιωτική Πελατεία "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_561_004, "Πωλήσεις αγαθών και υπηρεσιών Λιανικές βάσει άρθρου 39α παρ 5 του Κώδικα Φ.Π.Α. (Ν.2859/2000) "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_561_005, "Πωλήσεις αγαθών και υπηρεσιών Εξωτερικού Ενδοκοινοτικές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_561_006, "Πωλήσεις αγαθών και υπηρεσιών Εξωτερικού Τρίτες Χώρες "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_561_007, "Πωλήσεις αγαθών και υπηρεσιών Λοιπά "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_562    , "Λοιπά συνήθη έσοδα "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_563    , "Πιστωτικοί τόκοι και συναφή έσοδα "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_564    , "Πιστωτικές συναλλαγματικές διαφορές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_565    , "Έσοδα συμμετοχών "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_566    , "Κέρδη από διάθεση μη κυκλοφορούντων περιουσιακών στοιχείων "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_567    , "Κέρδη από αναστροφή προβλέψεων και απομειώσεων "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_568    , "Κέρδη από επιμέτρηση στην εύλογη αξία "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_570    , "Ασυνήθη έσοδα και κέρδη "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_595    , "Έξοδα σε ιδιοπαραγωγή "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_596    , "Επιδοτήσεις - Επιχορηγήσεις "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_597    , "Επιδοτήσεις - Επιχορηγήσεις για επενδυτικούς σκοπούς - κάλυψη δαπανών "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_880_001, "Πωλήσεις Παγίων Χονδρικές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_880_002, "Πωλήσεις Παγίων Λιανικές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_880_003, "Πωλήσεις Παγίων Εξωτερικού Ενδοκοινοτικές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_880_004, "Πωλήσεις Παγίων Εξωτερικού Τρίτες Χώρες "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_881_001, "Πωλήσεις για λογ/σμο Τρίτων Χονδρικές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_881_002, "Πωλήσεις για λογ/σμο Τρίτων Λιανικές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_881_003, "Πωλήσεις για λογ/σμο Τρίτων Εξωτερικού Ενδοκοινοτικές "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_881_004, "Πωλήσεις για λογ/σμο Τρίτων Εξωτερικού Τρίτες Χώρες "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_598_001, "Πωλήσεις αγαθών που υπάγονται σε ΕΦΚ "));
                    fList.Add(new IncomeValue(IncomeClassificationValueType.E3_598_003, "Πωλήσεις για λογαριασμό αγροτών μέσω αγροτικού συνεταιρισμού κλπ"));
                 }

                return fList;
            }
        }
    }
}
