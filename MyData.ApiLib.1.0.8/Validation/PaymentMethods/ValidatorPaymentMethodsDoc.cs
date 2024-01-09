namespace MyData.ApiLib
{
    [Validator(typeof(PaymentMethodsDoc))]
    public class ValidatorPaymentMethodsDoc : Validator
    {
        public ValidatorPaymentMethodsDoc(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public PaymentMethodsDoc Model { get { return fModel as PaymentMethodsDoc; } }
    }
}