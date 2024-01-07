namespace MyData.ApiLib
{

    public class ValidatorInvoiceSummaryType : Validator
    {
        public ValidatorInvoiceSummaryType()
            : base(typeof(InvoiceSummaryType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoiceSummaryType, ParentModel, ErrorList);
        }

        void Validate(InvoiceSummaryType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }

}
