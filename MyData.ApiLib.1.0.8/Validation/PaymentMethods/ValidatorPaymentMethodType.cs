namespace MyData.ApiLib
{
    public class ValidatorPaymentMethodType : Validator
    {
        public ValidatorPaymentMethodType()
            : base(typeof(PaymentMethodType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as PaymentMethodType, ParentModel, ErrorList);
        }

        void Validate(PaymentMethodType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}