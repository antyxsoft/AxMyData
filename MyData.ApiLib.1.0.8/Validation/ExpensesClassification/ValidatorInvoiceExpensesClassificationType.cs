namespace MyData.ApiLib
{
    [Validator(typeof(InvoiceExpensesClassificationType))]
    public class ValidatorInvoiceExpensesClassificationType : Validator
    {
        public ValidatorInvoiceExpensesClassificationType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public InvoiceExpensesClassificationType Model { get { return fModel as InvoiceExpensesClassificationType; } }
    }
}