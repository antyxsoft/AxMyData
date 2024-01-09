namespace MyData.ApiLib
{
    [Validator(typeof(PaymentMethodType))]
    public class ValidatorPaymentMethodType : Validator
    {
        public ValidatorPaymentMethodType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public PaymentMethodType Model { get { return fModel as PaymentMethodType; } }
    }
}