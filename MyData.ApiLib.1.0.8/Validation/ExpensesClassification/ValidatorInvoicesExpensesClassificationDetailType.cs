namespace MyData.ApiLib
{
    [Validator(typeof(InvoicesExpensesClassificationDetailType))]
    public class ValidatorInvoicesExpensesClassificationDetailType : Validator
    {
        public ValidatorInvoicesExpensesClassificationDetailType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public InvoicesExpensesClassificationDetailType Model { get { return fModel as InvoicesExpensesClassificationDetailType; } }
    }
}