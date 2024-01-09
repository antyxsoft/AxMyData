namespace MyData.ApiLib
{
    [Validator(typeof(TransportDetailType))]
    public class ValidatorTransportDetailType : Validator
    {
        public ValidatorTransportDetailType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public TransportDetailType Model { get { return fModel as TransportDetailType; } }
    }
}
