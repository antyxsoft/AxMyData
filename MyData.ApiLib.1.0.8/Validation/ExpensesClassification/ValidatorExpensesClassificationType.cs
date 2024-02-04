using MyData.Xsd;

namespace MyData.ApiLib
{
    /// <summary>
    /// Ο τύπος ExpensesClassificationType (περιγράφεται παρακάτω) αποτελεί την βασική δομή του Χαρακτηρισμού Εξόδων 
    /// και εμπεριέχεται 
    /// <list type="bullet">
    /// <item>είτε σε κάθε γραμμής του παραστατικού ξεχωριστά (χαρακτηρισμός γραμμής), <see cref="InvoiceRowType.expensesClassification"/></item>
    /// <item>είτε στην περίληψη παραστατικού (άθροισμα χαρακτηρισμών ανά τύπο - κατηγορία), <see cref="InvoiceSummaryType.expensesClassification"/></item>
    /// <item>είτε στο αντικείμενο InvoiceExpensesClassificationType 
    /// όταν οι χαρακτηρισμοί εσόδων υποβάλλονται ξεχωριστά (βλ παράγραφος 4.2.3) <see cref="InvoicesExpensesClassificationDetailType.expensesClassificationDetailData"/></item>
    /// </list>
    /// <para>ΠΑΡΑΤΗΡΗΣΕΙΣ</para>
    /// <para>1) Οι τιμές των πεδίων classificationType, classificationCategory, vatCategory, vatExemptionCategory περιγράφονται αναλυτικά στους αντίστοιχους πίνακες του Παραρτήματος</para>
    /// <para>2) Το πεδίο id προσφέρεται για σειριακή αρίθμηση(1,2,3… κλπ) των χαρακτηρισμών εντός μιας γραμμής</para>
    /// <para>3) Τα πεδία vatAmount, vatCategory, vatExemptionCategory χρησιμοποιούνται μόνο για τους χαρακτηρισμούς εξόδων ΦΠΑ, διαφορετικά αγνοούνται</para>
    /// <para>4) Το πεδίο classificationCategory χρησιμοποιείται μόνο για τους χαρακτηρισμούς εξόδων Ε3, αλλιώς αγνοείται</para>
    /// </summary>
    [Validator(typeof(ExpensesClassificationType))]
    public class ValidatorExpensesClassificationType : Validator
    {
        public ValidatorExpensesClassificationType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }
        
        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
            Validate_amount();
            Validate_vatAmount();
        }

        // amount
        /// <summary>
        /// Σύνολο ΦΠΑ. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_amount()
        {
            if (Model.amount < 0)
                AddPropertyError(nameof(Model.amount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.amount = decimal.Round(Model.amount, 2, MidpointRounding.ToEven);
        }
        // vatAmount
        /// <summary>
        /// Ποσό ΦΠΑ. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_vatAmount()
        {
            if (Model.vatAmount.HasValue)
            {
                if (Model.vatAmount.Value < 0)
                    AddPropertyError(nameof(Model.vatAmount), "Η τιμή δεν μπορεί να είναι < 0");

                Model.vatAmount = decimal.Round(Model.vatAmount.Value, 2, MidpointRounding.ToEven);
            }
        }
        

        public ExpensesClassificationType Model { get { return fModel as ExpensesClassificationType; } }
    }
}