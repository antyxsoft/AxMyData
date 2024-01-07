namespace MyData.ApiLib
{
    public class ValidatorOtherDeliveryNoteHeaderType : Validator
    {
        public ValidatorOtherDeliveryNoteHeaderType()
            : base(typeof(OtherDeliveryNoteHeaderType))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as OtherDeliveryNoteHeaderType, ParentModel, ErrorList);
        }

        void Validate(OtherDeliveryNoteHeaderType Model, object ParentModel, List<string> ErrorList)
        {
            Validators.ValidatePropertiesByAttributes(Model, ErrorList);
        }
    }
}