namespace MyData.ApiLib
{
    [Validator(typeof(InvoiceSummaryType))]
    public class ValidatorInvoiceSummaryType : Validator
    {
        public ValidatorInvoiceSummaryType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);

            Validate_totalNetValue();
            Validate_totalVatAmount();
            Validate_totalWithheldAmount();
            Validate_totalFeesAmount();
            Validate_totalStampDutyAmount();
            Validate_totalOtherTaxesAmount();
            Validate_totalDeductionsAmount();
            Validate_totalGrossValue();
        }


        /// <summary>
        /// Σύνολο Καθαρής Αξίας. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalNetValue()
        {
            if (Model.totalNetValue < 0)
                AddPropertyError(nameof(Model.totalNetValue), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalNetValue = decimal.Round(Model.totalNetValue, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Σύνολο ΦΠΑ. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalVatAmount()
        {
            if (Model.totalVatAmount < 0)
                AddPropertyError(nameof(Model.totalVatAmount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalVatAmount = decimal.Round(Model.totalVatAmount, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Σύνολο Παρακρατήσεων Φόρων. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalWithheldAmount()
        {
            if (Model.totalWithheldAmount < 0)
                AddPropertyError(nameof(Model.totalWithheldAmount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalWithheldAmount = decimal.Round(Model.totalWithheldAmount, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Σύνολο Τελών. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalFeesAmount()
        {
            if (Model.totalFeesAmount < 0)
                AddPropertyError(nameof(Model.totalFeesAmount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalFeesAmount = decimal.Round(Model.totalFeesAmount, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Σύνολο Χαρτοσήμου. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalStampDutyAmount()
        {
            if (Model.totalStampDutyAmount < 0)
                AddPropertyError(nameof(Model.totalStampDutyAmount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalStampDutyAmount = decimal.Round(Model.totalStampDutyAmount, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Σύνολο Λοιπών Φόρων. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalOtherTaxesAmount()
        {
            if (Model.totalOtherTaxesAmount < 0)
                AddPropertyError(nameof(Model.totalOtherTaxesAmount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalOtherTaxesAmount = decimal.Round(Model.totalOtherTaxesAmount, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Σύνολο Κρατήσεων. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalDeductionsAmount()
        {
            if (Model.totalDeductionsAmount < 0)
                AddPropertyError(nameof(Model.totalDeductionsAmount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalDeductionsAmount = decimal.Round(Model.totalDeductionsAmount, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Συνολική Αξία. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_totalGrossValue()
        {
            if (Model.totalGrossValue < 0)
                AddPropertyError(nameof(Model.totalGrossValue), "Η τιμή δεν μπορεί να είναι < 0");

            Model.totalGrossValue = decimal.Round(Model.totalGrossValue, 2, MidpointRounding.ToEven);
        }

        /* TODO: ValidatorInvoiceSummaryType
         * 
            1) Τα στοιχεία incomeClassification και expensesClassification 
                περιέχουν τα αθροίσματα για κάθε συνδυασμό τιμών 
                των πεδίων classificationType και classificationCategory 
                που εντοπίζονται στις γραμμές του παραστατικού

            2) Όλα τα πεδία αθροισμάτων φόρων εκτός του totalVatAmount 
                θα περιέχουν είτε τα αθροίσματα των αντίστοιχων φόρων των γραμμών του παραστατικού, 
                είτε τα αθροίσματα των αντίστοιχων φόρων που περιέχονται στο στοιχείο taxesTotals 
         */
        public InvoiceSummaryType Model { get { return fModel as InvoiceSummaryType; } }
    }

}
