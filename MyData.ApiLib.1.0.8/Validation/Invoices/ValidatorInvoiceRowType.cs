namespace MyData.ApiLib
{
 

    public class ValidatorInvoiceRowType : Validator
    {
        public ValidatorInvoiceRowType()
            : base(typeof(InvoiceRowType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoiceRowType, ParentModel, ErrorList);
        }

        void Validate(InvoiceRowType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }

}
