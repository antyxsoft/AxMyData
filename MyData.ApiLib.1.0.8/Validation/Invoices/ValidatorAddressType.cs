namespace MyData.ApiLib 
{

    [Validator(typeof(AddressType))]
    public class ValidatorAddressType : Validator
    {
        public ValidatorAddressType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public AddressType Model { get { return fModel as AddressType; } }
    }
}
