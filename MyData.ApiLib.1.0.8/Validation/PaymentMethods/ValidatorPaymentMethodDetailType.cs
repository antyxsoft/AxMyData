namespace MyData.ApiLib
{

    [Validator(typeof(PaymentMethodDetailType))]
    public class ValidatorPaymentMethodDetailType : Validator
    {
        public ValidatorPaymentMethodDetailType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);

            Validate_amount();
            Validate_tipAmount();
            Validate_transactionId();
            Validate_ProvidersSignature();
            Validate_ECRToken();
        }

        void Validate_amount()
        {
            /*  amount
                Ελάχιστη τιμή = 0 
                Δεκαδικά ψηφία = 2     
                NOTE: Το πεδίο amount μπορεί να αντιστοιχεί σε ένα τμήμα της συνολικής αξίας του παραστατικού
             */
            if (Model.amount < 0)
            {
                AddPropertyError(nameof(Model.amount), "Η τιμή δεν μπορεί να είναι < 0");
            }

            Model.amount = decimal.Round(Model.amount, 2, MidpointRounding.ToEven);
        }
        void Validate_tipAmount()
        {
            /*  tipAmount
                Ελάχιστη τιμή = 0 
                Δεκαδικά ψηφία = 2             
             */
            if (Model.tipAmount.HasValue)
            {
                if (Model.tipAmount.Value < 0)
                {
                    AddPropertyError(nameof(Model.tipAmount), "Η τιμή δεν μπορεί να είναι < 0");
                }

                Model.tipAmount = decimal.Round(Model.tipAmount.Value, 2, MidpointRounding.ToEven);
            }
        }
        void Validate_transactionId()
        {
            /*  transactionId
                Το πεδίο transactionId διαβιβάζεται στην περίπτωση πληρωμών με type = 7
             */

            if (Model.type == 7 && string.IsNullOrWhiteSpace(Model.transactionId))
            {
                AddPropertyError(nameof(Model.transactionId), "Το πεδίο είναι υποχρεωτικό οταν ο Τύπος Πληρωμής = 7");
            }
        }
        void Validate_ProvidersSignature()
        {
            /*  ProvidersSignature
                Το πεδίο ProvidersSignature είναι τύπου ProviderSignatureType, 
                διαβιβάζεται στην περίπτωση πληρωμών με type = 7 
                και όταν η διαβίβαση γίνεται από το κανάλι του παρόχου
             */

            if (Model.type == 7 && (Model.ProvidersSignature == null || Validators.IsInvoicingProvider))
            {
                AddPropertyError(nameof(Model.ProvidersSignature), "Το πεδίο είναι υποχρεωτικό οταν ο Τύπος Πληρωμής = 7 ή όταν η διαβίβαση γίνεται από Πάροχο");
            }

            // TODO: ProvidersSignature 
        }
        void Validate_ECRToken()
        {
            /*  ProvidersSignature
                Το πεδίο ProvidersSignature είναι τύπου ProviderSignatureType, 
                διαβιβάζεται στην περίπτωση πληρωμών με type = 7 
                και όταν η διαβίβαση γίνεται από το κανάλι του παρόχου
             */

            if (Model.type == 7 && (Model.ECRToken == null || Validators.IsInvoicingProvider))
            {
                AddPropertyError(nameof(Model.ECRToken), "Το πεδίο είναι υποχρεωτικό οταν ο Τύπος Πληρωμής = 7 ή όταν η διαβίβαση γίνεται από Πάροχο");
            }
        }

        public PaymentMethodDetailType Model { get { return fModel as PaymentMethodDetailType; } }
    }

}

