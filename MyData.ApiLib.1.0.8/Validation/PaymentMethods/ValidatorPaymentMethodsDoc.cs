namespace MyData.ApiLib
{
    public class ValidatorPaymentMethodsDoc : Validator
    {
        public ValidatorPaymentMethodsDoc()
            : base(typeof(PaymentMethodsDoc))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as PaymentMethodsDoc, ParentModel, ErrorList);
        }

        void Validate(PaymentMethodsDoc Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}