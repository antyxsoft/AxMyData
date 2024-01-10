namespace MyData.ApiLib
{

    [Validator(typeof(TaxTotalsType))]
    public class ValidatorTaxTotalsType : Validator
    {
        public ValidatorTaxTotalsType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);

            Validate_taxCategory();
        }

        /// <summary>
        /// Κατηγορία Φόρου. Ελάχιστη τιμή = 1.
        /// <para>Το πεδίο taxCategory μπορεί να πάρει κάθε φορά οποιαδήποτε τιμή από τον αντίστοιχο πίνακα του Παραρτήματος του φόρου που αναφέρεται στο πεδίο taxType</para>
        /// </summary>
        void Validate_taxCategory()
        {
            if (Model.taxCategory.HasValue)
            {
                // TODO: taxCategory
            }
        }

   

        public TaxTotalsType Model { get { return fModel as TaxTotalsType; } }
    }
}
