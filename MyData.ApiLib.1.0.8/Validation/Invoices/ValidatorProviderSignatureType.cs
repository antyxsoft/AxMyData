namespace MyData.ApiLib
{

    [Validator(typeof(ProviderSignatureType))]
    public class ValidatorProviderSignatureType : Validator
    {
        public ValidatorProviderSignatureType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public ProviderSignatureType Model { get { return fModel as ProviderSignatureType; } }
    }
}