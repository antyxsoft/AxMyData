namespace MyData.ApiLib
{
    public class ValidatorIncomeClassificationType : Validator
    {
        public ValidatorIncomeClassificationType()
            : base(typeof(IncomeClassificationType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as IncomeClassificationType, ParentModel, ErrorList);
        }

        void Validate(IncomeClassificationType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}