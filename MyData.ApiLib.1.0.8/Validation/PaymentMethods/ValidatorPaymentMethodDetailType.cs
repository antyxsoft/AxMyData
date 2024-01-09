namespace MyData.ApiLib
{
    public class ValidatorPaymentMethodDetailType : Validator
    {
        public ValidatorPaymentMethodDetailType()
            : base(typeof(PaymentMethodDetailType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as PaymentMethodDetailType, ParentModel, ErrorList);
        }

        void Validate(PaymentMethodDetailType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
            Validate_amount(Model, ParentModel, ErrorList);
            Validate_tipAmount(Model, ParentModel, ErrorList);
            Validate_transactionId(Model, ParentModel, ErrorList);
            Validate_ProvidersSignature(Model, ParentModel, ErrorList);
            Validate_ECRToken(Model, ParentModel, ErrorList);
        }

        void Validate_amount(PaymentMethodDetailType Model, object ParentModel, List<string> ErrorList)
        {
            /*  amount
                Ελάχιστη τιμή = 0 
                Δεκαδικά ψηφία = 2     
                NOTE: Το πεδίο amount μπορεί να αντιστοιχεί σε ένα τμήμα της συνολικής αξίας του παραστατικού
             */
            if (Model.amount < 0)
            {
                string ErrorMessage = Validators.FormatPropertyError(Model, nameof(Model.amount), "Η τιμή δεν μπορεί να είναι < 0");
                ErrorList.Add(ErrorMessage);
            }

            Model.amount = decimal.Round(Model.amount, 2, MidpointRounding.ToEven);
        }
        void Validate_tipAmount(PaymentMethodDetailType Model, object ParentModel, List<string> ErrorList)
        {
            /*  tipAmount
                Ελάχιστη τιμή = 0 
                Δεκαδικά ψηφία = 2             
             */
            if (!Model.tipAmount.HasValue)
            {
                if (Model.tipAmount.Value < 0)
                {
                    string ErrorMessage = Validators.FormatPropertyError(Model, nameof(Model.tipAmount), "Η τιμή δεν μπορεί να είναι < 0");
                    ErrorList.Add(ErrorMessage);
                }

                Model.tipAmount = decimal.Round(Model.tipAmount.Value, 2, MidpointRounding.ToEven);
            }
        }
        void Validate_transactionId(PaymentMethodDetailType Model, object ParentModel, List<string> ErrorList)
        {
            /*  transactionId
                Το πεδίο transactionId διαβιβάζεται στην περίπτωση πληρωμών με type = 7
             */

            if (Model.type == 7 && string.IsNullOrWhiteSpace(Model.transactionId))
            {
                string ErrorMessage = Validators.FormatPropertyError(Model, nameof(Model.transactionId), "Το πεδίο είναι υποχρεωτικό οταν ο Τύπος Πληρωμής = 7");
                ErrorList.Add(ErrorMessage);
            }
        }
        void Validate_ProvidersSignature(PaymentMethodDetailType Model, object ParentModel, List<string> ErrorList)
        {
            /*  ProvidersSignature
                Το πεδίο ProvidersSignature είναι τύπου ProviderSignatureType, 
                διαβιβάζεται στην περίπτωση πληρωμών με type = 7 
                και όταν η διαβίβαση γίνεται από το κανάλι του παρόχου
             */

            if (Model.type == 7 && (Model.ProvidersSignature == null || Validators.IsInvoicingProvider))
            {
                string ErrorMessage = Validators.FormatPropertyError(Model, nameof(Model.ProvidersSignature), "Το πεδίο είναι υποχρεωτικό οταν ο Τύπος Πληρωμής = 7 ή όταν η διαβίβαση γίνεται από Πάροχο");
                ErrorList.Add(ErrorMessage);
            }

            // TODO: ProvidersSignature 
        }
        void Validate_ECRToken(PaymentMethodDetailType Model, object ParentModel, List<string> ErrorList)
        {
            /*  ProvidersSignature
                Το πεδίο ProvidersSignature είναι τύπου ProviderSignatureType, 
                διαβιβάζεται στην περίπτωση πληρωμών με type = 7 
                και όταν η διαβίβαση γίνεται από το κανάλι του παρόχου
             */

            if (Model.type == 7 && (Model.ECRToken == null || Validators.IsInvoicingProvider))
            {
                string ErrorMessage = Validators.FormatPropertyError(Model, nameof(Model.ECRToken), "Το πεδίο είναι υποχρεωτικό οταν ο Τύπος Πληρωμής = 7 ή όταν η διαβίβαση γίνεται από Πάροχο");
                ErrorList.Add(ErrorMessage);
            }
        }
    

    }

}

