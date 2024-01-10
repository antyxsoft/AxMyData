namespace MyData.ApiLib
{
    [Validator(typeof(AadeBookInvoiceType))]
    public class ValidatorAadeBookInvoiceType : Validator
    {
        public ValidatorAadeBookInvoiceType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }
        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
            Validate_taxesTotals();
            Validate_issuer();
            Validate_counterpart();

            // TODO: Οι χαρακτηρισμοί που αφορούν τον υποβάλλοντα (εκδότης – εσόδων, λήπτης εξόδων), υποβάλλονται μαζί με το παραστατικό με την αντίστοιχη χρήση των πεδίων incomeClassification – expensesClassification
        }

        void Validate_taxesTotals()
        {
            /*  taxesTotals
                Στο στοιχείο taxesTotals θα περιλαμβάνονται φόροι όλων των κατηγοριών, εκτός του ΦΠΑ, 
                οι οποίοι αφορούν όλο το παραστατικό σαν σύνολο. 
                Σε περίπτωση που ο χρήστης κάνει χρήση αυτού του στοιχείου, 
                δεν θα μπορεί να εισάγει φόρους εκτός του ΦΠΑ σε κάθε γραμμή του παραστατικού ξεχωριστά */

            if (Model.taxesTotals != null && Model.taxesTotals.Count > 0)
            {
                // TODO: taxesTotals
            }
        }
        void Validate_issuer()
        {
            /*  issuer
                Για τον εκδότη, τα στοιχεία Επωνυμία και Διεύθυνση δεν γίνονται αποδεκτά στην περίπτωση που αφορούν οντότητα εντός Ελλάδας (GR).
             */

            // TODO: issuer
        }
        void Validate_counterpart()
        {
            /*  counterpart
                1. Για τον λήπτη, το στοιχείο Επωνυμία δεν γίνονται αποδεκτό στην περίπτωση που αφορά οντότητα εντός Ελλάδας (GR)

                2. counterpart.supplyAccountNo
                Έγκυρο μόνο στην περίπτωση παραστατικών καυσίμων.
                Ο αριθμός Παροχής Ηλ. Ρεύματος, είναι επιτρεπτός μόνο στην περίπτωση διαβίβασης παραστατικών καυσίμων 
                (το πεδίο της επικεφαλίδας του παραστατικού fuelInvoice έχει την τιμή true – αποδεκτό μόνο για διαβίβαση από παρόχους)
                και είναι πληροφορία του λήπτη του παραστατικού.

                3. countryDocumentId
                Ο κωδικός χώρας έκδοσης του επίσημου εγγράφου (π.χ διαβατηρίου), 
                είναι επιτρεπτός μόνο στην περίπτωση διαβίβασης παραστατικών που ανήκουν στην Ειδική Κατηγορία Παραστατικού Tax free 
                (το πεδίο της επικεφαλίδας του παραστατικού specialInvoiceCategory έχει την τιμή 4) 
                και εφόσον έχει συμπληρωθεί το πεδίο αριθμός επίσημου εγγράφου (documentIdNo) 
                και αφορά τον λήπτη του παραστατικού.
             */

            // TODO: counterpart
        }

        public AadeBookInvoiceType Model { get { return fModel as AadeBookInvoiceType; } }
    }
}
