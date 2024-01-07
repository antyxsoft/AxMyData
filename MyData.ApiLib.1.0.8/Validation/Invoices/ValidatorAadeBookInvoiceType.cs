namespace MyData.ApiLib
{
    public class ValidatorAadeBookInvoiceType : Validator
    {
        public ValidatorAadeBookInvoiceType()
            : base(typeof(AadeBookInvoiceType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as AadeBookInvoiceType, ParentModel, ErrorList);
        }

        void Validate(AadeBookInvoiceType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}
