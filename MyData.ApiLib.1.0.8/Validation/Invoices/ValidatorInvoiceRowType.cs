namespace MyData.ApiLib
{
    /// <summary>
    /// A validator class
    /// </summary>
    [Validator(typeof(InvoiceRowType))]
    public class ValidatorInvoiceRowType : Validator
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public ValidatorInvoiceRowType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        /// <summary>
        /// Validates the model.
        /// <para>Adds error messages to the context error list if the model does not pass the validation checks.</para>
        /// </summary>
        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        /// <summary>
        /// Returns the model.
        /// </summary>
        public InvoiceRowType Model { get { return fModel as InvoiceRowType; } }
    }

}
