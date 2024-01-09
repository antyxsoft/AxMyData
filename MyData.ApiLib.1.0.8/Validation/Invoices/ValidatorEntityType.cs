namespace MyData.ApiLib
{
    [Validator(typeof(EntityType))]
    public class ValidatorEntityType : Validator
    {
        public ValidatorEntityType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public EntityType Model { get { return fModel as EntityType; } }
    }
}