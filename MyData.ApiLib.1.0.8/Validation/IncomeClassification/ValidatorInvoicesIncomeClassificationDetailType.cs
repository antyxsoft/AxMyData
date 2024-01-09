namespace MyData.ApiLib
{
    [Validator(typeof(InvoicesIncomeClassificationDetailType))]
    public class ValidatorInvoicesIncomeClassificationDetailType : Validator
    {
        public ValidatorInvoicesIncomeClassificationDetailType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public InvoicesIncomeClassificationDetailType Model { get { return fModel as InvoicesIncomeClassificationDetailType; } }
    }
}