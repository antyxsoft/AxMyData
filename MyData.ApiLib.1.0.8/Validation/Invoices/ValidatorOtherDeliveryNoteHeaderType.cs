namespace MyData.ApiLib
{
    /// <summary>
    /// A validator class
    /// </summary>
    [Validator(typeof(OtherDeliveryNoteHeaderType))]
    public class ValidatorOtherDeliveryNoteHeaderType : Validator
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public ValidatorOtherDeliveryNoteHeaderType(object Model, ValidatorContext Context)
            : base(Model, Context)
        {
        }

        /// <summary>
        /// Validates the model.
        /// <para>Adds error messages to the context error list if the model does not pass the validation checks.</para>
        /// </summary>
        public override void Validate()
        {
            Validators.ValidatePropertiesByAttributes(Model, Context);
            Validate_loadingAddress();
            Validate_deliveryAddress();
        }

        /// <summary>
        /// Συμπληρώνεται για παραστατικά που είναι δελτία αποστολής (π.χ 9.3) ή τιμολόγιο και δελτίο αποστολής (isDeliveryNote = true)
        /// </summary>
        void Validate_loadingAddress()
        {
            if (Model.loadingAddress == null)
                AddPropertyError(nameof(Model.loadingAddress), "Απαιτείται τιμή για το πεδίο."); 
        }
        /// <summary>
        /// Συμπληρώνεται για παραστατικά που είναι δελτία αποστολής (π.χ 9.3) ή τιμολόγιο και δελτίο αποστολής (isDeliveryNote = true)
        /// </summary>
        void Validate_deliveryAddress()
        {
            if (Model.loadingAddress == null)
                AddPropertyError(nameof(Model.deliveryAddress), "Απαιτείται τιμή για το πεδίο.");
        }
 
        /// <summary>
        /// Returns the model.
        /// </summary>
        public OtherDeliveryNoteHeaderType Model { get { return fModel as OtherDeliveryNoteHeaderType; } }
    }
}