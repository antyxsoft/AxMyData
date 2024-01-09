namespace MyData.ApiLib
{

    [Validator(typeof(InvoicesDoc))]
    public class ValidatorInvoicesDoc : Validator
    {
        public ValidatorInvoicesDoc(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public InvoicesDoc Model { get { return fModel as InvoicesDoc; } }
    }


}
