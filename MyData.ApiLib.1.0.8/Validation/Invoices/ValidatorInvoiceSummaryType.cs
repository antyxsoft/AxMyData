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
        }

        public InvoiceSummaryType Model { get { return fModel as InvoiceSummaryType; } }
    }

}
