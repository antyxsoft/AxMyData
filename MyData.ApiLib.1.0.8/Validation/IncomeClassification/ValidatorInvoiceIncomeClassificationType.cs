namespace MyData.ApiLib
{
    [Validator(typeof(InvoiceIncomeClassificationType))]
    public class ValidatorInvoiceIncomeClassificationType : Validator
    {
        public ValidatorInvoiceIncomeClassificationType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public InvoiceIncomeClassificationType Model { get { return fModel as InvoiceIncomeClassificationType; } }
    }
}