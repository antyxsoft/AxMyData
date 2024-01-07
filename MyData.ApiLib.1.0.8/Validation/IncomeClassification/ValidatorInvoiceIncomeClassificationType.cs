namespace MyData.ApiLib
{
    public class ValidatorInvoiceIncomeClassificationType : Validator
    {
        public ValidatorInvoiceIncomeClassificationType()
            : base(typeof(InvoiceIncomeClassificationType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoiceIncomeClassificationType, ParentModel, ErrorList);
        }

        void Validate(InvoiceIncomeClassificationType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}