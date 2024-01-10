namespace MyData.ApiLib
{

    /// <summary>
    /// Ο τύπος IncomeClassificationType (περιγράφεται παρακάτω) 
    /// αποτελεί την βασική δομή του Χαρακτηρισμού Εσόδων 
    /// και εμπεριέχεται 
    /// <list type="bullet">
    /// <item>είτε σε κάθε γραμμής του παραστατικού ξεχωριστά (χαρακτηρισμός γραμμής), <see cref="InvoiceRowType.incomeClassification"/> </item>
    /// <item>είτε στην περίληψη παραστατικού (άθροισμα χαρακτηρισμών ανά τύπο - κατηγορία), <see cref="InvoiceSummaryType.incomeClassification"/> </item>
    /// <item>είτε στο αντικείμενο InvoiceIncomeClassificationType 
    /// όταν οι χαρακτηρισμοί εσόδων υποβάλλονται ξεχωριστά (βλ παράγραφος 4.2.2) <see cref="InvoicesIncomeClassificationDetailType.incomeClassificationDetailData"/></item>
    /// </list>
    /// <para>ΠΑΡΑΤΗΡΗΣΕΙΣ</para>
    /// <para>
    /// 1) Οι τιμές των πεδίων classificationType και classificationType (για του χαρακτηρισμούς εσόδων) 
    /// περιγράφονται αναλυτικά στους αντίστοιχους πίνακες του Παραρτήματος
    /// </para>
    /// <para>
    /// 2) Το πεδίο id προσφέρεται για σειριακή αρίθμηση(1,2,3… κλπ) των χαρακτηρισμών εντός μιας γραμμής
    /// </para> 
    /// </summary>
    [Validator(typeof(IncomeClassificationType))]
    public class ValidatorIncomeClassificationType : Validator
    {
        public ValidatorIncomeClassificationType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
            Validate_amount();
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

        public IncomeClassificationType Model { get { return fModel as IncomeClassificationType; } }
    }
}