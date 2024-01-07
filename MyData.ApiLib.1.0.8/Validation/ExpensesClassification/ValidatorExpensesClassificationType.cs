namespace MyData.ApiLib
{
    public class ValidatorExpensesClassificationType : Validator
    {
        public ValidatorExpensesClassificationType()
            : base(typeof(ExpensesClassificationType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as ExpensesClassificationType, ParentModel, ErrorList);
        }

        void Validate(ExpensesClassificationType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}