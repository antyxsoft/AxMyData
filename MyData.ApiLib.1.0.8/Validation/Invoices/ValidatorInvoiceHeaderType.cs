namespace MyData.ApiLib
{

    [Validator(typeof(InvoiceHeaderType))]
    public class ValidatorInvoiceHeaderType : Validator
    {
        public ValidatorInvoiceHeaderType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);

            Validate_series();
            Validate_selfPricing();
            Validate_invoiceType();
            Validate_exchangeRate();
            Validate_isDeliveryNote();
            Validate_fuelInvoice();
            Validate_invoiceVariationType();
            Validate_otherMovePurposeTitle();
            Validate_thirdPartyCollection();
        }
 
        void Validate_series()
        {
            /*  series
                Σε περίπτωση μη έκδοσης σειράς παραστατικού, το πεδίο series πρέπει να έχει την τιμή 0
            */

            // TODO: series
        }
        void Validate_selfPricing()
        {
            /*  selfPricing
                Το πεδίο selfPricing ορίζει αν πρόκειται για Τιμολόγιο Αυτοτιμολόγησης
            */

            // TODO: selfPricing
        }
        void Validate_invoiceType()
        {
            /*  invoiceType
                [Για την περίπτωση των παρόχων μόνο οι τιμές 1.1 έως και 11.5 είναι επιτρεπτές]
            */

            // TODO: invoiceType
        }
        void Validate_exchangeRate()
        {
            /*  exchangeRate
                Ελάχιστη τιμή = 0
                Δεκαδικά ψηφία = 5
                To πεδίο exchangeRate είναι η ισοτιμία του νομίσματος σε σχέση με το ευρώ. 
                Πρέπει να συμπληρώνεται μόνο όταν το νόμισμα δεν έχει τιμή EUR.
            */

            if (Model.exchangeRate.HasValue)
            {
                if (Model.currency == CurrencyType.EUR)
                {
                    AddPropertyError(nameof(Model.exchangeRate), "Πρέπει να συμπληρώνεται μόνο όταν το νόμισμα δεν έχει τιμή EUR");
                }

                if (Model.exchangeRate.Value < 0)
                {
                    AddPropertyError(nameof(Model.exchangeRate), "Η τιμή δεν μπορεί να είναι < 0");
                }

                Model.exchangeRate = decimal.Round(Model.exchangeRate.Value, 5, MidpointRounding.ToEven);
            }
 
        }
        void Validate_isDeliveryNote()
        {
            /*  isDeliveryNote
                Το πεδίο isDeliveryNote ορίζει αν πρόκειται για τιμολόγιο που είναι και δελτίο αποστολής (π.χ το παραστατικό τύπου 1.1 - Τιμολόγιο Πώλησης, 
                εφόσον φέρει την ένδειξη isDeliveryNote = true, τότε είναι και δελτίο διακίνησης και θα πρέπει να αποσταλούν και επιπλέον στοιχεία διακίνησης)
            */

            // TODO: isDeliveryNote
        }
        void Validate_fuelInvoice()
        {
            /*  fuelInvoice
                Αποδεκτό μόνο στην περίπτωση αποστολής από παρόχους.
                Το πεδίο fuelInvoice ορίζει αν πρόκειται για παραστατικό πώλησης υγρών καυσίμων καυσίμων 
                και επιτρέπεται η αποστολή μόνο για την περίπτωση των παρόχων.
            */

            // TODO: fuelInvoice
        }
        void Validate_invoiceVariationType()
        {
            /*  invoiceVariationType
                Δεν επιτρέπεται στη περίπτωση αποστολής μέσω παρόχων
            */

            // TODO: invoiceVariationType
        }
        void Validate_otherMovePurposeTitle()
        {
            /*  otherMovePurposeTitle
                Αποδεκτό μόνο για την περίπτωση που movePurpose = 19 (Λοιπές Διακινήσεις)
                Το πεδίο otherMovePurposeTitle συμπληρώνεται όταν έχει επιλεγεί ως movePurpose = 19 (Λοιπές Διακινήσεις) 
                και ορίζει τον τίτλο της άλλης διάκινησης
            */

            // TODO: otherMovePurposeTitle
        }
        void Validate_thirdPartyCollection()
        {
            /*  thirdPartyCollection
                Αποδεκτό μόνο για παραστατικά τύπωνμ 8.4 και 8.5
                Το πεδίο thirdPartyCollection ορίζει αν η επιχείρηση που κάνει χρήση Μέσων Πληρωμών ως Χρήστης υπηρεσιών πληρωμών 
                και εισπράττει για λογαριασμό τρίτων (περίπτωση παραστατικού 8.4 - Απόδειξη Είσπραξης POS) 
                ή αν επιστρέφει ποσά συναλλαγής για λογαριασμό τρίτων (περίπτωση παραστατικού 8.5 - Απόδειξη Επιστροφής POS)
            */

            // TODO: thirdPartyCollection
        }

        public InvoiceHeaderType Model { get { return fModel as InvoiceHeaderType; } }
    }
}
 
