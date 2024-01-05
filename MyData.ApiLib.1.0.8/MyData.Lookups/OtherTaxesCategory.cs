namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Κατηγορία Λοιπών Φόρων
    /// <para>FOR: <see cref="InvoiceRowType.otherTaxesPercentCategory"/> property </para>
    /// <para>XSD Type: OtherTaxesType</para>
    /// </summary>
    public class OtherTaxesCategory
    {
        static List<OtherTaxesCategory> fList;
 
        public OtherTaxesCategory(int Value, string Name, string Amount)
        {
            this.Value = Value;
            this.Name = Name.Trim();
            this.Amount = Amount;
        }

        public override string ToString()
        {
            return Name;
        }

        public int Value { get; }
        public string Name { get; }
        public string Amount { get; }

        static public List<OtherTaxesCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<OtherTaxesCategory>();
                    fList.Add(new OtherTaxesCategory( 1, "α1) ασφάλιστρα κλάδου πυρός 20%																								", "15% "));
                    fList.Add(new OtherTaxesCategory( 2, "α2) ασφάλιστρα κλάδου πυρός 20%																								", "5% "));
                    fList.Add(new OtherTaxesCategory( 3, "β) ασφάλιστρα κλάδου ζωής 4%																									", "4% "));
                    fList.Add(new OtherTaxesCategory( 4, "γ) ασφάλιστρα λοιπών κλάδων 15%.																								", "15% "));
                    fList.Add(new OtherTaxesCategory( 5, "δ) απαλλασσόμενα φόρου ασφαλίστρων 0%.																						", "0% "));
                    fList.Add(new OtherTaxesCategory( 6, "Ξενοδοχεία 1-2 αστέρων 0,50 €																								", "ποσό"));
                    fList.Add(new OtherTaxesCategory( 7, "Ξενοδοχεία 3 αστέρων 1,50 €																									", "ποσό"));
                    fList.Add(new OtherTaxesCategory( 8, "Ξενοδοχεία 4 αστέρων 3,00 €																									", "ποσό"));
                    fList.Add(new OtherTaxesCategory( 9, "Ξενοδοχεία 4 αστέρων 4,00 €																									", "ποσό"));
                    fList.Add(new OtherTaxesCategory(10, "Ενοικιαζόμενα - επιπλωμένα δωμάτια - διαμερίσματα 0,50 €																		", "ποσό"));
                    fList.Add(new OtherTaxesCategory(11, "Ειδικός Φόρος στις διαφημίσεις που προβάλλονται από την τηλεόραση (ΕΦΤΔ) 5%													", "5% "));
                    fList.Add(new OtherTaxesCategory(12, "3.1 Φόρος πολυτελείας 10% επί της φορολογητέας αξίας για τα ενδοκοινοτικώς αποκτούμενα και εισαγόμενα από τρίτες χώρες 10%	", "10% "));
                    fList.Add(new OtherTaxesCategory(13, "3.2 Φόρος πολυτελείας 10% επί της τιμής πώλησης προ Φ.Π.Α. για τα εγχωρίως παραγόμενα είδη 10%								", "10% "));
                    fList.Add(new OtherTaxesCategory(14, "Δικαίωμα του Δημοσίου στα εισιτήρια των καζίνο (80% επί του εισιτηρίου)														", "80% "));
                    fList.Add(new OtherTaxesCategory(15, "ασφάλιστρα κλάδου πυρός 20%																									", "20% "));
                    fList.Add(new OtherTaxesCategory(16, "Λοιποί Τελωνειακοί Δασμοί-Φόροι																								", "ποσό"));
                    fList.Add(new OtherTaxesCategory(17, "Λοιποί Φόροι ποσό 18 Επιβαρύνσεις Λοιπών Φόρων																				", "ποσό"));
                    fList.Add(new OtherTaxesCategory(19, "ΕΦΚ																															", "ποσό"));
                }

                return fList;
            }
        }
    }
}
