namespace MyData.ApiLib
{
    public class ValidatorProviderSignatureType : Validator
    {
        public ValidatorProviderSignatureType()
            : base(typeof(ProviderSignatureType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as ProviderSignatureType, ParentModel, ErrorList);
        }

        void Validate(ProviderSignatureType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}