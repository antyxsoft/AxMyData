namespace MyData.ApiLib
{

    [Validator(typeof(PartyType))]
    public class ValidatorPartyType : Validator
    {
        public ValidatorPartyType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);

            Validate_branch();
            Validate_documentIdNo();
            // Validate_supplyAccountNo(Model);     // in ValidatorAadeBookInvoiceType
            // Validate_countryDocumentId(Model);   // in ValidatorAadeBookInvoiceType
        }

        void Validate_branch()
        {
            // branch
            // Ελάχιστη τιμή = 0
            // Σε περίπτωση που η εγκατάσταση του εκδότη είναι η έδρα ή δεν υφίσταται, το πεδίο branch πρέπει να έχει την τιμή 0
            if (Model.branch < 0)
            {
                AddPropertyError(nameof(Model.branch), "Η τιμή δεν μπορεί να είναι < 0");
            }
        }
        void Validate_documentIdNo()
        {
            /*  documentIdNo
                Έγκυρο μόνο στην περίπτωση παραστατικού tax free (specialInvoiceCategory = 4) 
                Ο αριθμός επίσημου εγγράφου, είναι επιτρεπτός μόνο στην περίπτωση διαβίβασης παραστατικών 
                που ανήκουν στην Ειδική Κατηγορία Παραστατικού Tax free 
                (το πεδίο της επικεφαλίδας του παραστατικού specialInvoiceCategory έχει την τιμή 4), 
                και μπορεί να είναι οποιοδήποτε επίσημο έγγραφο ταυτοποίησης 
                (π.χ αριθμός διαβατηρίου) του λήπτη του παραστατικού.*/

            // TODO: documentIdNo
        }

        public PartyType Model { get { return fModel as PartyType; } }

    }


}
