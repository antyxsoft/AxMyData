namespace MyData.ApiLib
{

    [Validator(typeof(ShipType))]
    public class ValidatorShipType : Validator
    {
        public ValidatorShipType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public ShipType Model { get { return fModel as ShipType; } }
    }
}