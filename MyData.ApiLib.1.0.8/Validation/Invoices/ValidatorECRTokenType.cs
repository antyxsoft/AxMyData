namespace MyData.ApiLib
{
    [Validator(typeof(ECRTokenType))]
    public class ValidatorECRTokenType : Validator
    {
        public ValidatorECRTokenType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public ECRTokenType Model { get { return fModel as ECRTokenType; } }
    }
}
