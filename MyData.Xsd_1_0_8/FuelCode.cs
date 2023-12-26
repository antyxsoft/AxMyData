namespace MyData.Xsd
{

    /// Παράρτημα: Κωδικοί Καυσίμων
    /// <para>FOR: <see cref="InvoiceRowType.fuelCode"/> property</para>
    /// <para>XSD Type: FuelCodes </para>
    /// <para>NOTE: helper for AADE <see cref="FuelCodes"/> enum </para>
    /// </summary>
    public class FuelCategory
    {
        static List<FuelCategory> fList;

        public FuelCategory(FuelCodes Value, string Name)
        {
            this.Value = Value;
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public FuelCodes Value { get; }
        public string Name { get; }

        public static List<FuelCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<FuelCategory>();

                    fList.Add(new FuelCategory(FuelCodes.Item10, "Benzine 95RON"));
                    fList.Add(new FuelCategory(FuelCodes.Item11 , "Benzine 95RON+"));
                    fList.Add(new FuelCategory(FuelCodes.Item12 , "Benzine 100RON"));
                    fList.Add(new FuelCategory(FuelCodes.Item13 , "Benzine LRP"));
                    fList.Add(new FuelCategory(FuelCodes.Item14 , "Βενζίνη αεροπλάνων"));
                    fList.Add(new FuelCategory(FuelCodes.Item15 , "Ειδικό καύσιμο αεριωθουμένων"));
                    fList.Add(new FuelCategory(FuelCodes.Item20 , "Diesel"));
                    fList.Add(new FuelCategory(FuelCodes.Item21 , "Diesel premium"));
                    fList.Add(new FuelCategory(FuelCodes.Item30 , "Diesel Heatnn"));
                    fList.Add(new FuelCategory(FuelCodes.Item31 , "Diesel Heat premium"));
                    fList.Add(new FuelCategory(FuelCodes.Item32 , "Diesel Light"));
                    fList.Add(new FuelCategory(FuelCodes.Item33 , "Diesel άλλων χρήσεων"));
                    fList.Add(new FuelCategory(FuelCodes.Item34 , "Diesel ναυτιλίας"));
                    fList.Add(new FuelCategory(FuelCodes.Item35 , "Κηροζίνη JP1"));
                    fList.Add(new FuelCategory(FuelCodes.Item36 , "Κηροζίνη άλλων χρήσεων"));
                    fList.Add(new FuelCategory(FuelCodes.Item37 , "Μαζούτ"));
                    fList.Add(new FuelCategory(FuelCodes.Item38 , "Μαζούτ ναυτιλίας"));
                    fList.Add(new FuelCategory(FuelCodes.Item40 , "LPG (υγραέριο)"));
                    fList.Add(new FuelCategory(FuelCodes.Item41 , "Υγραέριο (LPG) και μεθάνιο βιομηχανικό /εμπορικό κινητήρων (χύδην)"));
                    fList.Add(new FuelCategory(FuelCodes.Item42 , "Υγραέριο (LPG) και μεθάνιο θέρμανσης και λοιπών χρήσεων (χύδην)"));
                    fList.Add(new FuelCategory(FuelCodes.Item43 , "Υγραέριο (LPG) και μεθάνιο βιομηχανικό /εμπορικό κινητήρων (σε φιάλες)"));
                    fList.Add(new FuelCategory(FuelCodes.Item44 , "Υγραέριο (LPG) και μεθάνιο θέρμανσης και λοιπών χρήσεων (σε φιάλες)"));
                    fList.Add(new FuelCategory(FuelCodes.Item50 , "CNG (πεπιεσμένο φυσικό αέριο)"));
                    fList.Add(new FuelCategory(FuelCodes.Item60 , "Αρωματικοί Υδρογονάνθρακες Δασμολογικής Κλάσης 2707"));
                    fList.Add(new FuelCategory(FuelCodes.Item61 , "Κυκλικοί Υδρογονάνθρακες Δασμολογικής Κλάσης 2902"));
                    fList.Add(new FuelCategory(FuelCodes.Item70 , "Ελαφρύ πετρέλαιο (WHITE SPIRIT)"));
                    fList.Add(new FuelCategory(FuelCodes.Item71 , "Ελαφριά λάδια"));
                    fList.Add(new FuelCategory(FuelCodes.Item72 , "Βιοντίζελ"));
                    fList.Add(new FuelCategory(FuelCodes.Item999, "Λοιπές χρεώσεις υπηρεσιών"));

                }

                return fList;
            }
        }
    }
}
