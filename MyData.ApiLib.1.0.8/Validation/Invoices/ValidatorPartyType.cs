namespace MyData.ApiLib
{
    public class ValidatorPartyType : Validator
    {
        public ValidatorPartyType()
            : base(typeof(PartyType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as PartyType, ParentModel, ErrorList);
        }

        void Validate(PartyType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
            Validate_branch(Model, ParentModel, ErrorList);
            Validate_documentIdNo(Model, ParentModel, ErrorList);
            // Validate_supplyAccountNo(Model, ParentModel, ErrorList);     // in ValidatorAadeBookInvoiceType
            // Validate_countryDocumentId(Model, ParentModel, ErrorList);   // in ValidatorAadeBookInvoiceType
        }

        void Validate_branch(PartyType Model, object ParentModel, List<string> ErrorList)
        {
            // branch
            // Ελάχιστη τιμή = 0
            // Σε περίπτωση που η εγκατάσταση του εκδότη είναι η έδρα ή δεν υφίσταται, το πεδίο branch πρέπει να έχει την τιμή 0
            if (Model.branch < 0)
            {
                string ErrorMessage = Validators.FormatPropertyError(Model, nameof(Model.branch), "Η τιμή δεν μπορεί να είναι < 0");
                ErrorList.Add(ErrorMessage);
            }
        }
        void Validate_documentIdNo(PartyType Model, object ParentModel, List<string> ErrorList)
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
 
 

    }


}
