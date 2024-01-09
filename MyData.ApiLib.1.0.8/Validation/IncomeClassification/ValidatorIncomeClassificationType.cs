namespace MyData.ApiLib
{
    [Validator(typeof(IncomeClassificationType))]
    public class ValidatorIncomeClassificationType : Validator
    {
        public ValidatorIncomeClassificationType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public IncomeClassificationType Model { get { return fModel as IncomeClassificationType; } }
    }
}