namespace MyData.ApiLib
{

    [Validator(typeof(OtherDeliveryNoteHeaderType))]
    public class ValidatorOtherDeliveryNoteHeaderType : Validator
    {
        public ValidatorOtherDeliveryNoteHeaderType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
        }

        public OtherDeliveryNoteHeaderType Model { get { return fModel as OtherDeliveryNoteHeaderType; } }
    }
}