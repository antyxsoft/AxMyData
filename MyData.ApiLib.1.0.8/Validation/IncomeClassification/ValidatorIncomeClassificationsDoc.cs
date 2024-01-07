namespace MyData.ApiLib
{
    public class ValidatorIncomeClassificationsDoc : Validator
    {
        public ValidatorIncomeClassificationsDoc()
            : base(typeof(IncomeClassificationsDoc))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as IncomeClassificationsDoc, ParentModel, ErrorList);
        }

        void Validate(IncomeClassificationsDoc Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}