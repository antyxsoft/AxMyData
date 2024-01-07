namespace MyData.ApiLib
{
 

    public class ValidatorTaxTotalsType : Validator
    {
        public ValidatorTaxTotalsType()
            : base(typeof(TaxTotalsType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as TaxTotalsType, ParentModel, ErrorList);
        }

        void Validate(TaxTotalsType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}
