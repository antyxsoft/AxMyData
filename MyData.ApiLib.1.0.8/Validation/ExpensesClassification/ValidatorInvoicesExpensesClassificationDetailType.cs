namespace MyData.ApiLib
{
    public class ValidatorInvoicesExpensesClassificationDetailType : Validator
    {
        public ValidatorInvoicesExpensesClassificationDetailType()
            : base(typeof(InvoicesExpensesClassificationDetailType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoicesExpensesClassificationDetailType, ParentModel, ErrorList);
        }

        void Validate(InvoicesExpensesClassificationDetailType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}