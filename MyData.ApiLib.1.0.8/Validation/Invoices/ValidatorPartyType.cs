namespace MyData.ApiLib
{
    public class ValidatorPartyType : Validator
    {
        public ValidatorPartyType()
            : base(typeof(PartyType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as PartyType, ParentModel, ErrorList);
        }

        void Validate(PartyType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }


}
