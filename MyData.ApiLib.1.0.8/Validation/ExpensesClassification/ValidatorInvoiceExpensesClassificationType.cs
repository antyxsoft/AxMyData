namespace MyData.ApiLib
{
    public class ValidatorInvoiceExpensesClassificationType : Validator
    {
        public ValidatorInvoiceExpensesClassificationType()
            : base(typeof(InvoiceExpensesClassificationType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoiceExpensesClassificationType, ParentModel, ErrorList);
        }

        void Validate(InvoiceExpensesClassificationType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}