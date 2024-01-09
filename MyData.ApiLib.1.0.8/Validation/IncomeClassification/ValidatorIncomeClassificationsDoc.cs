namespace MyData.ApiLib
{
    [Validator(typeof(IncomeClassificationsDoc))]
    public class ValidatorIncomeClassificationsDoc : Validator
    {
        public ValidatorIncomeClassificationsDoc(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public IncomeClassificationsDoc Model { get { return fModel as IncomeClassificationsDoc; } }
    }
}