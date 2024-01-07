namespace MyData.ApiLib
{
    public class ValidatorShipType : Validator
    {
        public ValidatorShipType()
            : base(typeof(ShipType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as ShipType, ParentModel, ErrorList);
        }

        void Validate(ShipType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}