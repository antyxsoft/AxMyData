namespace MyData.ApiLib
{
    public class ValidatorPaymentMethodDetailType : Validator
    {
        public ValidatorPaymentMethodDetailType()
            : base(typeof(PaymentMethodDetailType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as PaymentMethodDetailType, ParentModel, ErrorList);
        }

        void Validate(PaymentMethodDetailType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }

}

