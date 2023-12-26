namespace MyData.Xsd
{

    /// <summary>
    /// Παράρτημα: Είδη παραστατικών
    /// <para>FOR: <see cref="InvoiceHeaderType.invoiceType"/> property </para>
    /// <para>XSD Type: InvoiceType </para>
    /// <para>NOTE: helper for AADE <see cref="InvoiceType"/> enum </para>
    /// </summary>
    public class InvoiceCategory
    {
        static List<InvoiceCategory> fList;
 
        public InvoiceCategory(string Code, InvoiceType Value, string Category, string Name)
        {
            this.Code = Code;
            this.Value = Value;
            this.Category = Category;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public string Category { get; }
        public string Code { get; }
        public InvoiceType Value { get; }
        public string Name { get; }

        static public List<InvoiceCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<InvoiceCategory>();

                    // Αντικριζόμενα Παραστατικά Εκδότη ημεδαπής / αλλοδαπής
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("1.1", InvoiceType.Item11, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης"));
                    fList.Add(new InvoiceCategory("1.2", InvoiceType.Item12, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Ενδοκοινοτικές Παραδόσεις"));
                    fList.Add(new InvoiceCategory("1.3", InvoiceType.Item13, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Παραδόσεις Τρίτων Χωρών"));
                    fList.Add(new InvoiceCategory("1.4", InvoiceType.Item14, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Πώληση για Λογαριασμό Τρίτων"));
                    fList.Add(new InvoiceCategory("1.5", InvoiceType.Item15, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Εκκαθάριση Πωλήσεων Τρίτων - Αμοιβή από Πωλήσεις Τρίτων"));
                    fList.Add(new InvoiceCategory("1.6", InvoiceType.Item16, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Συμπληρωματικό Παραστατικό "));

                    fList.Add(new InvoiceCategory("2.1", InvoiceType.Item21, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής"));
                    fList.Add(new InvoiceCategory("2.2", InvoiceType.Item22, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής / Ενδοκοινοτική Παροχή Υπηρεσιών"));
                    fList.Add(new InvoiceCategory("2.3", InvoiceType.Item23, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής / Παροχή Υπηρεσιών σε λήπτη Τρίτης Χώρας"));
                    fList.Add(new InvoiceCategory("2.4", InvoiceType.Item24, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής / Συμπληρωματικό Παραστατικό"));

                    fList.Add(new InvoiceCategory("3.1", InvoiceType.Item31, "Τίτλος Κτήσης", "Τίτλος Κτήσης (μη υπόχρεος Εκδότης)"));
                    fList.Add(new InvoiceCategory("3.2", InvoiceType.Item32, "Τίτλος Κτήσης", "Τίτλος Κτήσης (άρνηση έκδοσης από υπόχρεο Εκδότη)"));

                    fList.Add(new InvoiceCategory("4", InvoiceType.Item4, "Για Μελλοντική Χρήση", ""));

                    fList.Add(new InvoiceCategory("5.1", InvoiceType.Item51, "Πιστωτικό Τιμολόγιο", "Πιστωτικό Τιμολόγιο / Συσχετιζόμενο"));
                    fList.Add(new InvoiceCategory("5.2", InvoiceType.Item52, "Πιστωτικό Τιμολόγιο", "Πιστωτικό Τιμολόγιο / Μη Συσχετιζόμενο"));

                    fList.Add(new InvoiceCategory("6.1", InvoiceType.Item61, "Στοιχείο Αυτοπαράδοσης - Ιδιοχρησιμοποίησης", "Στοιχείο Αυτοπαράδοσης"));
                    fList.Add(new InvoiceCategory("6.2", InvoiceType.Item62, "Στοιχείο Αυτοπαράδοσης - Ιδιοχρησιμοποίησης", "Στοιχείο Ιδιοχρησιμοποίησης"));

                    fList.Add(new InvoiceCategory("7.1", InvoiceType.Item71, "Συμβόλαιο - Έσοδο", "Συμβόλαιο - Έσοδο"));

                    fList.Add(new InvoiceCategory("8.1", InvoiceType.Item81, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Ενοίκια - Έσοδο"));
                    fList.Add(new InvoiceCategory("8.2", InvoiceType.Item82, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Ειδικό Στοιχείο – Απόδειξης Είσπραξης Φόρου Διαμονής"));
                    fList.Add(new InvoiceCategory("8.4", InvoiceType.Item84, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Απόδειξη Είσπραξης POS"));
                    fList.Add(new InvoiceCategory("8.5", InvoiceType.Item85, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Απόδειξη Επιστροφής POS"));
                    fList.Add(new InvoiceCategory("8.6", InvoiceType.Item86, "Δελτίο Παραγγελίας", "Δελτίο Παραγγελίας Εστίασης"));

                    fList.Add(new InvoiceCategory("9.3", InvoiceType.Item93, "Παραστατικό Διακίνησης", "Παραστατικό Διακίνησης Μη Συσχετιζόμενο"));


                    // Μη Αντικριζόμενα Παραστατικά Εκδότη ημεδαπής / αλλοδαπής 
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("11.1", InvoiceType.Item111, "Παραστατικά Λιανικής", "ΑΛΠ"));
                    fList.Add(new InvoiceCategory("11.2", InvoiceType.Item112, "Παραστατικά Λιανικής", "ΑΠΥ"));
                    fList.Add(new InvoiceCategory("11.3", InvoiceType.Item113, "Παραστατικά Λιανικής", "Απλοποιημένο Τιμολόγιο"));
                    fList.Add(new InvoiceCategory("11.4", InvoiceType.Item114, "Παραστατικά Λιανικής", "Πιστωτικό Στοιχ. Λιανικής"));
                    fList.Add(new InvoiceCategory("11.5", InvoiceType.Item115, "Παραστατικά Λιανικής", "Απόδειξη Λιανικής Πώλησης για Λογ/σμό Τρίτων"));

                    fList.Add(new InvoiceCategory("12", InvoiceType.Item12, "Για Μελλοντική Χρήση", ""));


                    // Μη Αντικριζόμενα Παραστατικά Λήπτη ημεδαπής / αλλοδαπής
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("13.1", InvoiceType.Item13, "Λήψη Παραστατικών Λιανικής", "Έξοδα - Αγορές Λιανικών Συναλλαγών ημεδαπής / αλλοδαπής"));
                    fList.Add(new InvoiceCategory("13.2", InvoiceType.Item13, "Λήψη Παραστατικών Λιανικής", "Παροχή Λιανικών Συναλλαγών ημεδαπής / αλλοδαπής"));
                    fList.Add(new InvoiceCategory("13.3", InvoiceType.Item13, "Λήψη Παραστατικών Λιανικής", "Κοινόχρηστα"));
                    fList.Add(new InvoiceCategory("13.4", InvoiceType.Item13, "Λήψη Παραστατικών Λιανικής", "Συνδρομές"));
                    fList.Add(new InvoiceCategory("13.30", InvoiceType.Item13, "Λήψη Παραστατικών Λιανικής", "Παραστατικά Οντότητας ως Αναγράφονται από την ίδια (Δυναμικό)"));
                    fList.Add(new InvoiceCategory("13.31", InvoiceType.Item13, "Λήψη Παραστατικών Λιανικής", "Πιστωτικό Στοιχ. Λιανικής ημεδαπής / αλλοδαπής"));


                    // Αντικριζόμενα Παραστατικά Λήπτη ημεδαπής / αλλοδαπής
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("14.1", InvoiceType.Item141, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.2", InvoiceType.Item142, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.3", InvoiceType.Item143, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.4", InvoiceType.Item144, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.5", InvoiceType.Item145, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.30", InvoiceType.Item1430, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.31", InvoiceType.Item1431, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));

                    fList.Add(new InvoiceCategory("15.1", InvoiceType.Item151, "Συμβόλαιο - Έξοδο", "Συμβόλαιο - Έξοδο"));

                    fList.Add(new InvoiceCategory("16.1", InvoiceType.Item161, "Ειδικό Στοιχείο (Έξοδο) – Απόδειξη Πληρωμής", "Ενοίκιο Έξοδο"));

                    // Εγγραφές Τακτοποίησης Εσόδων-Εξόδων
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("17.1", InvoiceType.Item171, "Εγγραφές Οντότητας", "Μισθοδοσία"));
                    fList.Add(new InvoiceCategory("17.2", InvoiceType.Item172, "Εγγραφές Οντότητας", "Αποσβέσεις"));
                    fList.Add(new InvoiceCategory("17.3", InvoiceType.Item173, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εσόδων - Λογιστική Βάση"));
                    fList.Add(new InvoiceCategory("17.4", InvoiceType.Item174, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εσόδων - Φορολογική Βάση"));
                    fList.Add(new InvoiceCategory("17.5", InvoiceType.Item175, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εξόδων - Λογιστική Βάση"));
                    fList.Add(new InvoiceCategory("17.6", InvoiceType.Item176, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εξόδων - Φορολογική Βάση "));
                }

                return fList;
            }
        }

 
    }
}
