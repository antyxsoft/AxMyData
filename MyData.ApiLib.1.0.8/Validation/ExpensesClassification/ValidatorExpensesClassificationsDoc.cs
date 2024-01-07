namespace MyData.ApiLib
{
    public class ValidatorExpensesClassificationsDoc : Validator
    {
        public ValidatorExpensesClassificationsDoc()
            : base(typeof(ExpensesClassificationsDoc))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as ExpensesClassificationsDoc, ParentModel, ErrorList);
        }

        void Validate(ExpensesClassificationsDoc Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}