namespace MyData.ApiLib
{

    [Validator(typeof(TaxTotalsType))]
    public class ValidatorTaxTotalsType : Validator
    {
        public ValidatorTaxTotalsType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public TaxTotalsType Model { get { return fModel as TaxTotalsType; } }
    }
}
