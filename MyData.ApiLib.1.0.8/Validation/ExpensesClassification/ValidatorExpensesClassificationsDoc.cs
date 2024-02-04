namespace MyData.ApiLib
{
    [Validator(typeof(ExpensesClassificationsDoc))]
    public class ValidatorExpensesClassificationsDoc : Validator
    {
        public ValidatorExpensesClassificationsDoc(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public ExpensesClassificationsDoc Model { get { return fModel as ExpensesClassificationsDoc; } }
    }
}