namespace MyData.ApiLib
{
    public class ValidatorAadeBookInvoiceType : Validator
    {
        public ValidatorAadeBookInvoiceType()
            : base(typeof(AadeBookInvoiceType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as AadeBookInvoiceType, ParentModel, ErrorList);
        }

        void Validate(AadeBookInvoiceType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
            Validate_taxesTotals(Model, ParentModel, ErrorList);
            Validate_issuer(Model, ParentModel, ErrorList);
            Validate_counterpart(Model, ParentModel, ErrorList);
        }

        void Validate_taxesTotals(AadeBookInvoiceType Model, object ParentModel, List<string> ErrorList)
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

        void Validate_issuer(AadeBookInvoiceType Model, object ParentModel, List<string> ErrorList)
        {
            /*  issuer
                Για τον εκδότη, τα στοιχεία Επωνυμία και Διεύθυνση δεν γίνονται αποδεκτά στην περίπτωση που αφορούν οντότητα εντός Ελλάδας (GR).
             */

            // TODO: issuer
        }
        void Validate_counterpart(AadeBookInvoiceType Model, object ParentModel, List<string> ErrorList)
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
    }
}
