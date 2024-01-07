namespace MyData.ApiLib
{
    public class ValidatorTransportDetailType : Validator
    {
        public ValidatorTransportDetailType()
            : base(typeof(TransportDetailType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as TransportDetailType, ParentModel, ErrorList);
        }

        void Validate(TransportDetailType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}
