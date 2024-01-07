namespace MyData.ApiLib
{
    public class ValidatorInvoicesIncomeClassificationDetailType : Validator
    {
        public ValidatorInvoicesIncomeClassificationDetailType()
            : base(typeof(InvoicesIncomeClassificationDetailType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoicesIncomeClassificationDetailType, ParentModel, ErrorList);
        }

        void Validate(InvoicesIncomeClassificationDetailType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}