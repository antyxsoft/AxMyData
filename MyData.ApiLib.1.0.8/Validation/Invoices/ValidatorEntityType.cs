namespace MyData.ApiLib
{
    public class ValidatorEntityType : Validator
    {
        public ValidatorEntityType()
            : base(typeof(EntityType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as EntityType, ParentModel, ErrorList);
        }

        void Validate(EntityType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}