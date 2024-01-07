namespace MyData.ApiLib 
{
    public class ValidatorAddressType : Validator
    {
        public ValidatorAddressType()
            : base(typeof(AddressType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as AddressType, ParentModel, ErrorList);
        }

        void Validate(AddressType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}
