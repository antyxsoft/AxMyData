namespace MyData.Xsd
{
    /// <summary>
    /// Παράρτημα: Κατηγορία Παρακρατούμενων Φόρων
    /// <para>FOR: <see cref="InvoiceRowType.withheldPercentCategory"/> property </para>
    /// <para>XSD Type: WithheldType</para>
    /// </summary>
    public class TaxWithheldCategory
    {
        static List<TaxWithheldCategory> fList;

        public TaxWithheldCategory(int Value, string Name, string Amount)
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

        static public List<TaxWithheldCategory> List
        {
            get
            {
                if (fList == null)
                {
                    fList = new List<TaxWithheldCategory>();
                    fList.Add(new TaxWithheldCategory(1, "Περιπτ. β’- Τόκοι - 15%                                                                                              ", "15% "));
                    fList.Add(new TaxWithheldCategory(2 , "Περιπτ. γ’ - Δικαιώματα - 20%                                                                                        ", "20% "));
                    fList.Add(new TaxWithheldCategory(3 , "Περιπτ. δ’ - Αμοιβές Συμβουλών Διοίκησης - 20%                                                                       ", "20% "));
                    fList.Add(new TaxWithheldCategory(4 , "Περιπτ. δ’ - Τεχνικά Έργα - 3%                                                                                       ", "3% "));
                    fList.Add(new TaxWithheldCategory(5 , "Υγρά καύσιμα και προϊόντα καπνοβιομηχανίας 1%                                                                        ", "1% "));
                    fList.Add(new TaxWithheldCategory(6 , "Λοιπά Αγαθά 4%                                                                                                       ", "4% "));
                    fList.Add(new TaxWithheldCategory(7 , "Παροχή Υπηρεσιών 8%                                                                                                  ", "8% "));
                    fList.Add(new TaxWithheldCategory(8 , "Προκαταβλητέος Φόρος Αρχιτεκτόνων και Μηχανικών επί Συμβατικών Αμοιβών, για Εκπόνηση Μελετών και Σχεδίων 4%          ", "4% "));
                    fList.Add(new TaxWithheldCategory(9 , "Προκαταβλητέος Φόρος Αρχιτεκτόνων και Μηχανικών επί Συμβατικών Αμοιβών, που αφορούν οποιασδήποτε άλλης φύσης έργα 10%", "10% "));
                    fList.Add(new TaxWithheldCategory(10, "Προκαταβλητέος Φόρος στις Αμοιβές Δικηγόρων 15%                                                                      ", "15% "));
                    fList.Add(new TaxWithheldCategory(11, "Παρακράτηση Φόρου Μισθωτών Υπηρεσιών παρ. 1 αρ. 15 ν. 4172/2013                                                      ", "ποσό"));
                    fList.Add(new TaxWithheldCategory(12, "Παρακράτηση Φόρου Μισθωτών Υπηρεσιών παρ. 2 αρ. 15 ν. 4172/2013 - Αξιωματικών Εμπορικού Ναυτικού                     ", "15% "));
                    fList.Add(new TaxWithheldCategory(13, "Παρακράτηση Φόρου Μισθωτών Υπηρεσιών παρ. 2 αρ. 15 ν. 4172/2013 - Κατώτερο Πλήρωμα Εμπορικού Ναυτικού                ", "10% "));
                    fList.Add(new TaxWithheldCategory(14, "Παρακράτηση Ειδικής Εισφοράς Αλληλεγγύης                                                                             ", "ποσό"));
                    fList.Add(new TaxWithheldCategory(15, "Παρακράτηση Φόρου Αποζημίωσης λόγω Διακοπής Σχέσης Εργασίας παρ. 3 αρ. 15 ν. 4172/2013                               ", "ποσό"));
                    fList.Add(new TaxWithheldCategory(16, "Παρακρατήσεις συναλλαγών αλλοδαπής βάσει συμβάσεων αποφυγής διπλής φορολογίας (Σ.Α.Δ.Φ.)                             ", "ποσό"));
                    fList.Add(new TaxWithheldCategory(17, "Λοιπές Παρακρατήσεις Φόρου                                                                                           ", "ποσό"));
                    fList.Add(new TaxWithheldCategory(18, "Παρακράτηση Φόρου Μερίσματα περ.α παρ. 1 αρ. 64 ν. 4172/2013                                                         ", "5% "));

                }

                return fList;
            }
        }


    }
}
