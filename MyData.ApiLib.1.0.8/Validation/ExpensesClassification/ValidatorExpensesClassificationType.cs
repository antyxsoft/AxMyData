namespace MyData.ApiLib
{
    [Validator(typeof(ExpensesClassificationType))]
    public class ValidatorExpensesClassificationType : Validator
    {
        public ValidatorExpensesClassificationType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }
        
        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public ExpensesClassificationType Model { get { return fModel as ExpensesClassificationType; } }
    }
}