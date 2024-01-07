namespace MyData.ApiLib
{
 
    public class ValidatorInvoiceHeaderType : Validator
    {
        public ValidatorInvoiceHeaderType()
            : base(typeof(InvoiceHeaderType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoiceHeaderType, ParentModel, ErrorList);
        }

        void Validate(InvoiceHeaderType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}
 
