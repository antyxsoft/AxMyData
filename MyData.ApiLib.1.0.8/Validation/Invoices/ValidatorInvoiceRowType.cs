namespace MyData.ApiLib
{

    [Validator(typeof(InvoiceRowType))]
    public class ValidatorInvoiceRowType : Validator
    {
        public ValidatorInvoiceRowType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public InvoiceRowType Model { get { return fModel as InvoiceRowType; } }
    }

}
