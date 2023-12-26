namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Σκοπός Διακίνησης
    /// <para>FOR: <see cref="InvoiceHeaderType.movePurpose"/> property </para>
    /// <para>XSD Type: no type</para>
    /// </summary>
    public class MovePurpose
    {
        static List<MovePurpose> fList;

        public MovePurpose(int Value, string Name)
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

        public static List<MovePurpose> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<MovePurpose>();

                    fList.Add(new MovePurpose(1, "Πώληση "));
                    fList.Add(new MovePurpose(2 , "Πώληση για Λογαριασμό Τρίτων "));
                    fList.Add(new MovePurpose(3 , "Δειγματισμός "));
                    fList.Add(new MovePurpose(4 , "Έκθεση "));
                    fList.Add(new MovePurpose(5 , "Επιστροφή "));
                    fList.Add(new MovePurpose(6 , "Φύλαξη "));
                    fList.Add(new MovePurpose(7 , "Επεξεργασία Συναρμολόγηση "));
                    fList.Add(new MovePurpose(8 , "Μεταξύ Εγκαταστάσεων Οντότητας "));
                    fList.Add(new MovePurpose(9 , "Αγορά "));
                    fList.Add(new MovePurpose(10, "Εφοδιασμός πλοίων και αεροσκαφών"));
                    fList.Add(new MovePurpose(11, "Δωρεάν διάθεση "));
                    fList.Add(new MovePurpose(12, "Εγγύηση "));
                    fList.Add(new MovePurpose(13, "Χρησιδανεισμός "));
                    fList.Add(new MovePurpose(14, "Αποθήκευση σε Τρίτους "));
                    fList.Add(new MovePurpose(15, "Επιστροφή από Φύλαξη"));
                    fList.Add(new MovePurpose(16, "Ανακύκλωση "));
                    fList.Add(new MovePurpose(17, "Καταστροφή άχρηστου υλικού "));
                    fList.Add(new MovePurpose(18, "Διακίνηση Παγίων (Ενδοδιακίνηση)"));
                    fList.Add(new MovePurpose(19, "Λοιπές Διακινήσεις"));
                }

                return fList;
            }
        }
    }
}
