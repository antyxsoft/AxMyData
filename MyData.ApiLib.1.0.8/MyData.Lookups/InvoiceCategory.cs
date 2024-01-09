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
                    fList.Add(new InvoiceCategory("1.1", InvoiceType.Item1Period1, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης"));
                    fList.Add(new InvoiceCategory("1.2", InvoiceType.Item1Period2, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Ενδοκοινοτικές Παραδόσεις"));
                    fList.Add(new InvoiceCategory("1.3", InvoiceType.Item1Period3, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Παραδόσεις Τρίτων Χωρών"));
                    fList.Add(new InvoiceCategory("1.4", InvoiceType.Item1Period4, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Πώληση για Λογαριασμό Τρίτων"));
                    fList.Add(new InvoiceCategory("1.5", InvoiceType.Item1Period5, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Εκκαθάριση Πωλήσεων Τρίτων - Αμοιβή από Πωλήσεις Τρίτων"));
                    fList.Add(new InvoiceCategory("1.6", InvoiceType.Item1Period6, "Τιμολόγιο Πώλησης", "Τιμολόγιο Πώλησης / Συμπληρωματικό Παραστατικό "));
                                                                    
                    fList.Add(new InvoiceCategory("2.1", InvoiceType.Item2Period1, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής"));
                    fList.Add(new InvoiceCategory("2.2", InvoiceType.Item2Period2, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής / Ενδοκοινοτική Παροχή Υπηρεσιών"));
                    fList.Add(new InvoiceCategory("2.3", InvoiceType.Item2Period3, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής / Παροχή Υπηρεσιών σε λήπτη Τρίτης Χώρας"));
                    fList.Add(new InvoiceCategory("2.4", InvoiceType.Item2Period4, "Τιμολόγιο Παροχής Υπηρεσιών", "Τιμολόγιο Παροχής / Συμπληρωματικό Παραστατικό"));
                                                                     
                    fList.Add(new InvoiceCategory("3.1", InvoiceType.Item3Period1, "Τίτλος Κτήσης", "Τίτλος Κτήσης (μη υπόχρεος Εκδότης)"));
                    fList.Add(new InvoiceCategory("3.2", InvoiceType.Item3Period2, "Τίτλος Κτήσης", "Τίτλος Κτήσης (άρνηση έκδοσης από υπόχρεο Εκδότη)"));
                                                                   
                    fList.Add(new InvoiceCategory("4", InvoiceType.Item4, "Για Μελλοντική Χρήση", ""));
                                                                           
                    fList.Add(new InvoiceCategory("5.1", InvoiceType.Item5Period1, "Πιστωτικό Τιμολόγιο", "Πιστωτικό Τιμολόγιο / Συσχετιζόμενο"));
                    fList.Add(new InvoiceCategory("5.2", InvoiceType.Item5Period2, "Πιστωτικό Τιμολόγιο", "Πιστωτικό Τιμολόγιο / Μη Συσχετιζόμενο"));
                                                                           
                    fList.Add(new InvoiceCategory("6.1", InvoiceType.Item6Period1, "Στοιχείο Αυτοπαράδοσης - Ιδιοχρησιμοποίησης", "Στοιχείο Αυτοπαράδοσης"));
                    fList.Add(new InvoiceCategory("6.2", InvoiceType.Item6Period2, "Στοιχείο Αυτοπαράδοσης - Ιδιοχρησιμοποίησης", "Στοιχείο Ιδιοχρησιμοποίησης"));
                                                                           
                    fList.Add(new InvoiceCategory("7.1", InvoiceType.Item7Period1, "Συμβόλαιο - Έσοδο", "Συμβόλαιο - Έσοδο"));
                                                                           
                    fList.Add(new InvoiceCategory("8.1", InvoiceType.Item8Period1, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Ενοίκια - Έσοδο"));
                    fList.Add(new InvoiceCategory("8.2", InvoiceType.Item8Period2, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Ειδικό Στοιχείο – Απόδειξης Είσπραξης Φόρου Διαμονής"));
                    fList.Add(new InvoiceCategory("8.4", InvoiceType.Item8Period4, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Απόδειξη Είσπραξης POS"));
                    fList.Add(new InvoiceCategory("8.5", InvoiceType.Item8Period5, "Ειδικό Στοιχείο (Έσοδο) – Απόδειξη Είσπραξης", "Απόδειξη Επιστροφής POS"));
                    fList.Add(new InvoiceCategory("8.6", InvoiceType.Item8Period6, "Δελτίο Παραγγελίας", "Δελτίο Παραγγελίας Εστίασης"));
                                                                           
                    fList.Add(new InvoiceCategory("9.3", InvoiceType.Item9Period3, "Παραστατικό Διακίνησης", "Παραστατικό Διακίνησης Μη Συσχετιζόμενο"));


                    // Μη Αντικριζόμενα Παραστατικά Εκδότη ημεδαπής / αλλοδαπής 
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("11.1", InvoiceType.Item11Period1, "Παραστατικά Λιανικής", "ΑΛΠ"));
                    fList.Add(new InvoiceCategory("11.2", InvoiceType.Item11Period2, "Παραστατικά Λιανικής", "ΑΠΥ"));
                    fList.Add(new InvoiceCategory("11.3", InvoiceType.Item11Period3, "Παραστατικά Λιανικής", "Απλοποιημένο Τιμολόγιο"));
                    fList.Add(new InvoiceCategory("11.4", InvoiceType.Item11Period4, "Παραστατικά Λιανικής", "Πιστωτικό Στοιχ. Λιανικής"));
                    fList.Add(new InvoiceCategory("11.5", InvoiceType.Item11Period5, "Παραστατικά Λιανικής", "Απόδειξη Λιανικής Πώλησης για Λογ/σμό Τρίτων"));

                    fList.Add(new InvoiceCategory("12", InvoiceType.Item12, "Για Μελλοντική Χρήση", ""));


                    // Μη Αντικριζόμενα Παραστατικά Λήπτη ημεδαπής / αλλοδαπής
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("13.1",  InvoiceType.Item1Period3, "Λήψη Παραστατικών Λιανικής", "Έξοδα - Αγορές Λιανικών Συναλλαγών ημεδαπής / αλλοδαπής"));
                    fList.Add(new InvoiceCategory("13.2",  InvoiceType.Item1Period3, "Λήψη Παραστατικών Λιανικής", "Παροχή Λιανικών Συναλλαγών ημεδαπής / αλλοδαπής"));
                    fList.Add(new InvoiceCategory("13.3",  InvoiceType.Item1Period3, "Λήψη Παραστατικών Λιανικής", "Κοινόχρηστα"));
                    fList.Add(new InvoiceCategory("13.4",  InvoiceType.Item1Period3, "Λήψη Παραστατικών Λιανικής", "Συνδρομές"));
                    fList.Add(new InvoiceCategory("13.30", InvoiceType.Item1Period3, "Λήψη Παραστατικών Λιανικής", "Παραστατικά Οντότητας ως Αναγράφονται από την ίδια (Δυναμικό)"));
                    fList.Add(new InvoiceCategory("13.31", InvoiceType.Item1Period3, "Λήψη Παραστατικών Λιανικής", "Πιστωτικό Στοιχ. Λιανικής ημεδαπής / αλλοδαπής"));


                    // Αντικριζόμενα Παραστατικά Λήπτη ημεδαπής / αλλοδαπής
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("14.1",  InvoiceType.Item14Period1, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.2",  InvoiceType.Item14Period2, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.3",  InvoiceType.Item14Period3, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.4",  InvoiceType.Item14Period4, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.5",  InvoiceType.Item14Period5, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.30", InvoiceType.Item14Period30, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));
                    fList.Add(new InvoiceCategory("14.31", InvoiceType.Item14Period31, "Παραστ. Εξαιρ. Οντοτήτων ημεδαπής / αλλοδαπής", ""));

                    fList.Add(new InvoiceCategory("15.1", InvoiceType.Item15Period1, "Συμβόλαιο - Έξοδο", "Συμβόλαιο - Έξοδο"));

                    fList.Add(new InvoiceCategory("16.1", InvoiceType.Item16Period1, "Ειδικό Στοιχείο (Έξοδο) – Απόδειξη Πληρωμής", "Ενοίκιο Έξοδο"));

                    // Εγγραφές Τακτοποίησης Εσόδων-Εξόδων
                    //-------------------------------------------------------------------------------
                    fList.Add(new InvoiceCategory("17.1", InvoiceType.Item17Period1, "Εγγραφές Οντότητας", "Μισθοδοσία"));
                    fList.Add(new InvoiceCategory("17.2", InvoiceType.Item17Period2, "Εγγραφές Οντότητας", "Αποσβέσεις"));
                    fList.Add(new InvoiceCategory("17.3", InvoiceType.Item17Period3, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εσόδων - Λογιστική Βάση"));
                    fList.Add(new InvoiceCategory("17.4", InvoiceType.Item17Period4, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εσόδων - Φορολογική Βάση"));
                    fList.Add(new InvoiceCategory("17.5", InvoiceType.Item17Period5, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εξόδων - Λογιστική Βάση"));
                    fList.Add(new InvoiceCategory("17.6", InvoiceType.Item17Period6, "Εγγραφές Οντότητας", "Λοιπές Εγγραφές Τακτοποίησης Εξόδων - Φορολογική Βάση "));
                }

                return fList;
            }
        }
        static public bool Exists(InvoiceType Value)
        {
            return List.FirstOrDefault(item => item.Value == Value) != null;
        }


        /// <summary>
        /// True when it is a delivery note too (Δελτίο Αποστολής ή Τιμολόγιο + Δελτίο Αποστολής) 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        static public bool IsDeliveryDocument(InvoiceType Value)
        {
            return Value == InvoiceType.Item9Period3;
        }
    }
}
