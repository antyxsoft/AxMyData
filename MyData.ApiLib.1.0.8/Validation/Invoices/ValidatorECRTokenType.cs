namespace MyData.ApiLib
{
    public class ValidatorECRTokenType : Validator
    {
        public ValidatorECRTokenType()
            : base(typeof(ECRTokenType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as ECRTokenType, ParentModel, ErrorList);
        }

        void Validate(ECRTokenType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}
