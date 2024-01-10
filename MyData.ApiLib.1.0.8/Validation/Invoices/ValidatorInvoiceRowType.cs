namespace MyData.ApiLib
{
    /// <summary>
    /// A validator class
    /// </summary>
    [Validator(typeof(InvoiceRowType))]
    public class ValidatorInvoiceRowType : Validator
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public ValidatorInvoiceRowType(object Model, ValidatorContext Context)
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

            Validate_lineNumber();
            Validate_recType();
            Validate_fuelCode();
            Validate_quantity();
            Validate_netValue();
            Validate_vatCategory();
            Validate_vatAmount();
            Validate_withheldAmount();
            Validate_stampDutyAmount();
            Validate_feesAmount();
            Validate_otherTaxesAmount();
            Validate_deductionsAmount();
            Validate_quantity15();
            Validate_itemDescr();
            Validate_TaricNo();
            Validate_itemCode();
            Validate_otherMeasurementUnitQuantity();
            Validate_otherMeasurementUnitTitle();
            Validate_vatExemptionCategory();
        }

        /// <summary>
        /// ΑΑ γραμμής. Ελάχιστη τιμή = 1
        /// </summary>
        void Validate_lineNumber()
        {
            if (Model.lineNumber < 1)
                AddPropertyError(nameof(Model.lineNumber), "Η τιμή πρέπει να είναι > 0 .");
        }
        /// <summary>
        /// Είδος Γραμμής. Ελάχιστη τιμή = 1. Μέγιστη τιμή = 7
        /// Σημείωση: Στην παρούσα έκδοση οι τιμές 1, 4 και 5 δεν θα μπορούν να χρησιμοποιηθούν – έχουν δεσμευτεί στο μοντέλο για μελλοντική χρήση
        /// </summary>
        void Validate_recType()
        {
            if (Model.recType.HasValue)
                if (Model.recType.Value == 1 || Model.recType.Value == 4 || Model.recType.Value == 5)
                    AddPropertyError(nameof(Model.recType), "Οι τιμές 1, 4 και 5 είναι μη έγκυρες. Εχουν δεσμευτεί για μελλοντική χρήση.");

            // TODO: recType
            /*
                α) Στην περίπτωση αποστολής γραμμών με recType = 2 (γραμμή τέλους με ΦΠΑ) 
                    ή/και recType = 3 (Γραμμή Λοιπών Φόρων με Φ.Π.Α.), 
                    θα επιτρέπεται παράλληλα, εφόσον είναι επιθυμητό, 
                    η αποστολή παρακρατούμενων /τελών /λοιπών φόρων/ χαρτοσήμου/ κρατήσεων 
                    και σε επίπεδο παραστατικού 
                    και όχι υποχρεωτικά ανά γραμμή σύνοψης παραστατικού. 

                    Στις περιπτώσεις αυτών των γραμμών, 
                    τα ποσά που αντιστοιχούν στα τέλη με ΦΠΑ (recType = 2) 
                    ή τους λοιπούς φόρους (recType = 3) αντίστοιχα, 
                    θα αποστέλλονται στο πεδίο της καθαρής αξίας της γραμμής (netValue), 
                    ενώ τα αντίστοιχα πεδία ποσό τέλους (feesAmount) 
                    ή ποσό λοιπών φόρων (otherTaxesAmount) δεν θα συμπληρώνονται. 
                    
                    Επίσης στις γραμμές αυτές 
                    δεν επιτρέπεται η αποστολή άλλων ειδών φόρων/τελών/κρατήσεων/χαρτοσήμου 
                    (π.χ. σε μια γραμμή με recType = 2 
                    δεν επιτρέπονται στη γραμμή αυτή η αποστολή λοιπών φόρων/κρατήσεων/παρακρατούμενων/χαρτοσήμου).

                β) Η αποστολή με recType = 7 (αρνητικό πρόσημο αξιών) 
                    επιτρέπεται μόνο στην περίπτωση διαβίβασης παραστατικών 17.3, 17.4, 17.5 και 17.6 
                    και με αυτόν τον τρόπο υποδηλώνεται ότι οι αξίες της γραμμής είναι αρνητικές 
                    (στα αντίστοιχα πεδία των αξιών οι τιμές αναγράφονται στις απόλυτες/θετικές τιμές τους). 
            
                    Σημειώνεται ότι στα αθροίσματα των αξιών στην ενότητα Περίληψη Παραστατικού (InvoiceSummaryType) 
                    θα διαβιβάζονται τα αθροίσματα των απόλυτων τιμών των αντίστοιχων αξιών των γραμμών ανεξάρτητα 
                    αν υπάρχουν γραμμές που φέρουν ή όχι την ένδειξη recType = 7.

             */
        }
        /// <summary>
        /// Κωδικός Καυσίμου. Αποδεκτό μόνο στην περίπτωση αποστολής από παρόχους 
        /// και για την περίπτωση που το παραστατικό είναι παραστατικό καυσίμων
        /// </summary>
        void Validate_fuelCode()
        {
            if (!Model.fuelCode.HasValue)
            {
                // TODO: fuelCode
                /*
                    Οι πιθανές τιμές για το πεδίο fuelCode (κωδικός καυσίμου) 
                    περιγράφονται αναλυτικά στον αντίστοιχο πίνακα του Παραρτήματος. 
                
                    Eπιτρέπεται η αποστολή του μόνο για την περίπτωση των παρόχων 
                    και εφόσον πρόκειται για παραστατικό καυσίμων (invoiceHeaderType.fuelInvoice = true). 
                
                    Η τιμή 999 χρησιμοποιείται στην περίπτωση που σε ένα παραστατικό 
                    εκτός από καύσιμα υπάρχει η ανάγκη τιμολόγησης και λοιπών χρεώσεων. 
                
                    Επιτρέπεται ανά παραστατικό μόνο μια γραμμή με αυτόν τον κωδικό 
                    και η καθαρή αξία αυτής της γραμμής θα πρέπει να είναι μικρότερη ή ίση 
                    από το άθροισμα της καθαρής αξίας των υπόλοιπων κωδικών καυσίμου του παραστατικού. 
                 */

            }
        }
        /// <summary>
        /// Ποσότητα. Ελάχιστη τιμή = 0
        /// </summary>
        void Validate_quantity()
        {
            if (!Model.quantity.HasValue)
                if (Model.quantity.Value < 0)
                    AddPropertyError(nameof(Model.quantity), "Τιμή < 0 είναι μη έγκυρη.");
        }
        /// <summary>
        /// Καθαρή αξία. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_netValue()
        {
            if (Model.netValue < 0)
                AddPropertyError(nameof(Model.netValue), "Η τιμή δεν μπορεί να είναι < 0");

            Model.netValue = decimal.Round(Model.netValue, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Κατηγορία ΦΠΑ. Για περιπτώσεις λογιστικών εγγραφών όπου δεν εφαρμόζεται ΦΠΑ, το πεδίο vatCategory θα έχει την τιμή 8
        /// </summary>
        void Validate_vatCategory()
        {
            // TODO: vatCategory
        }
        /// <summary>
        /// Ποσό ΦΠΑ. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_vatAmount()
        {
            if (Model.vatAmount < 0)
                AddPropertyError(nameof(Model.vatAmount), "Η τιμή δεν μπορεί να είναι < 0");

            Model.vatAmount = decimal.Round(Model.vatAmount, 2, MidpointRounding.ToEven);
        }
        /// <summary>
        /// Ποσό ΦΠΑ. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_withheldAmount()
        {
            if (Model.withheldAmount.HasValue && Model.withheldAmount.Value < 0)
            {
                AddPropertyError(nameof(Model.withheldAmount), "Η τιμή δεν μπορεί να είναι < 0");
                Model.withheldAmount = decimal.Round(Model.withheldAmount.Value, 2, MidpointRounding.ToEven);
            }
        }
        /// <summary>
        /// Ποσό Χαρτοσήμου. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_stampDutyAmount()
        {
            if (Model.stampDutyAmount.HasValue && Model.stampDutyAmount.Value < 0)
            {
                AddPropertyError(nameof(Model.stampDutyAmount), "Η τιμή δεν μπορεί να είναι < 0");
                Model.stampDutyAmount = decimal.Round(Model.stampDutyAmount.Value, 2, MidpointRounding.ToEven);
            } 
        }
        /// <summary>
        /// Ποσό Τελών. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_feesAmount()
        {
            if (Model.feesAmount.HasValue && Model.feesAmount.Value < 0)
            {
                AddPropertyError(nameof(Model.feesAmount), "Η τιμή δεν μπορεί να είναι < 0");
                Model.feesAmount = decimal.Round(Model.feesAmount.Value, 2, MidpointRounding.ToEven);
            }
        }
        /// <summary>
        /// Ποσό Λοιπών Φόρων. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_otherTaxesAmount()
        {
            if (Model.otherTaxesAmount.HasValue && Model.otherTaxesAmount.Value < 0)
            {
                AddPropertyError(nameof(Model.otherTaxesAmount), "Η τιμή δεν μπορεί να είναι < 0");
                Model.otherTaxesAmount = decimal.Round(Model.otherTaxesAmount.Value, 2, MidpointRounding.ToEven);
            }
        }
        /// <summary>
        ///  Ποσό Κρατήσεων. Ελάχιστη τιμή = 0. Δεκαδικά ψηφία = 2
        /// </summary>
        void Validate_deductionsAmount()
        {
            if (Model.deductionsAmount.HasValue && Model.deductionsAmount.Value < 0)
            {
                AddPropertyError(nameof(Model.deductionsAmount), "Η τιμή δεν μπορεί να είναι < 0");
                Model.deductionsAmount = decimal.Round(Model.deductionsAmount.Value, 2, MidpointRounding.ToEven);
            }
        }
        /// <summary>
        /// Ποσότητα Θερμοκρασίας 15 βαθμών. Ελάχιστη τιμή = 0. 
        /// Αποδεκτό μόνο στην περίπτωση αποστολής από παρόχους και για την περίπτωση που το παραστατικό είναι παραστατικό καυσίμων
        /// </summary>
        void Validate_quantity15()
        {
            if (Model.quantity15.HasValue)
            {
                if (Model.quantity15.Value < 0)
                    AddPropertyError(nameof(Model.quantity15), "Η τιμή δεν μπορεί να είναι < 0");

                // TODO: quantity15
            }
        }
        /// <summary>
        /// Περιγραφή Είδους. Αποδεκτό μόνο στην περίπτωση παραστατικών της ειδικής κατηγορίας tax free ή που είναι τιμολόγια και δελτία αποστολής ή απλά δελτία διακίνησης (π.χ 9.3)
        /// </summary>
        void Validate_itemDescr()
        {
            if (!string.IsNullOrWhiteSpace(Model.itemDescr))
            {
                // TODO: itemDescr
            }
        }
        /// <summary>
        /// Κωδικός Taric. Αποδεκτό μόνο στην περίπτωση παραστατικών που είναι τιμολόγια και δελτία αποστολής ή απλά δελτία διακίνησης(π.χ 9.3)
        /// </summary>
        void Validate_TaricNo()
        {
            if (!string.IsNullOrWhiteSpace(Model.TaricNo))
            {
                // TODO: TaricNo
            }
        }
        /// <summary>
        /// Κωδικός Είδους.  Αποδεκτό μόνο στην περίπτωση παραστατικών που είναι τιμολόγια και δελτία αποστολής ή απλά δελτία διακίνησης(π.χ 9.3)
        /// </summary>
        void Validate_itemCode()
        {
            if (!string.IsNullOrWhiteSpace(Model.itemCode))
            {
                // TODO: itemCode
            }
        }
        /// <summary>
        /// Πλήθος Μονάδας Μέτρησης Τεμάχια Άλλα.  Αποδεκτό μόνο στην περίπτωση που measurementUnit = 7(Τεμάχια_Λοιπές Περιπτώσεις)
        /// </summary>
        void Validate_otherMeasurementUnitQuantity()
        {
            if (Model.otherMeasurementUnitQuantity.HasValue)
            {
                if (Model.measurementUnit.HasValue && Model.measurementUnit.Value != 7)
                    AddPropertyError(nameof(Model.otherMeasurementUnitQuantity),
                        "Η τιμή είναι αποδεκτή μόνο όταν η Μον. Μέτρησης της γραμμής (measurementUnit) είναι Τεμάχια_Λοιπές Περιπτώσεις (7). ");
            }

            // TODO: otherMeasurementUnitQuantity
            /*
                Τα πεδία otherMeasurementUnitQuantity και otherMeasurementUnitTitle 
                συμπληρώνονται υποχρεωτικά στην περίπτωση που έχει επιλεγεί measurementUnit = 7 (Τεμάχια_Λοιπές Περιπτώσεις). 
            
                Με την επιλογή measurementUnit = 7 (Τεμάχια_Λοιπές Περιπτώσεις) ως μονάδα μέτρησης 
                για τις περιπτώσεις παραστατικών διακίνησης, 
                δίνεται η δυνατότητα να διαβιβαστεί η πληροφορία μονάδας μέτρησης 
                που δεν συμπεριλαμβάνεται σε κάποια από τις διαθέσιμες τιμές της λίστας, 
                με αριθμητική απεικόνιση του πλήθους (otherMeasurementUnitQuantity) 
                που αντιστοιχεί στο είδος συσκευασίας 
                και σύντομη αναγραφή του είδους συσκευασίας στο λεκτικό πεδίο (otherMeasurementUnitTitle) 
                π.χ. 3_Παλέτες. 
            
                Σημειώνεται ότι το πεδίο quantity («Ποσότητα») σε κάθε περίπτωση 
                αντιστοιχεί στο πλήθος των ειδών που διακινούνται και όχι στο πλήθος των ειδών συσκευασίας. 
             */
        }
        /// <summary>
        /// Τίτλος Μονάδας Μέτρησης Τεμάχια Άλλα.  Αποδεκτό μόνο στην περίπτωση που measurementUnit = 7(Τεμάχια_Λοιπές Περιπτώσεις)
        /// </summary>
        void Validate_otherMeasurementUnitTitle()
        {
            if (!string.IsNullOrWhiteSpace(Model.otherMeasurementUnitTitle))
            {
                if (Model.measurementUnit.HasValue && Model.measurementUnit.Value != 7)
                    AddPropertyError(nameof(Model.otherMeasurementUnitTitle),
                        "Η τιμή είναι αποδεκτή μόνο όταν η Μον. Μέτρησης της γραμμής (measurementUnit) είναι Τεμάχια_Λοιπές Περιπτώσεις (7). ");
            }

            // TODO: otherMeasurementUnitTitle
            /*
                Τα πεδία otherMeasurementUnitQuantity και otherMeasurementUnitTitle 
                συμπληρώνονται υποχρεωτικά στην περίπτωση που έχει επιλεγεί measurementUnit = 7 (Τεμάχια_Λοιπές Περιπτώσεις). 
            
                Με την επιλογή measurementUnit = 7 (Τεμάχια_Λοιπές Περιπτώσεις) ως μονάδα μέτρησης 
                για τις περιπτώσεις παραστατικών διακίνησης, 
                δίνεται η δυνατότητα να διαβιβαστεί η πληροφορία μονάδας μέτρησης 
                που δεν συμπεριλαμβάνεται σε κάποια από τις διαθέσιμες τιμές της λίστας, 
                με αριθμητική απεικόνιση του πλήθους (otherMeasurementUnitQuantity) 
                που αντιστοιχεί στο είδος συσκευασίας 
                και σύντομη αναγραφή του είδους συσκευασίας στο λεκτικό πεδίο (otherMeasurementUnitTitle) 
                π.χ. 3_Παλέτες. 
            
                Σημειώνεται ότι το πεδίο quantity («Ποσότητα») σε κάθε περίπτωση 
                αντιστοιχεί στο πλήθος των ειδών που διακινούνται και όχι στο πλήθος των ειδών συσκευασίας. 
             */
        }
        /// <summary>
        /// Κατηγορία Αιτίας Εξαίρεσης ΦΠΑ. Το πεδίο vatExemptionCategory είναι απαραίτητο στην περίπτωση που το vatCategory υποδηλώνει κατηγορία συντελεστή 0% ΦΠΑ
        /// </summary>
        void Validate_vatExemptionCategory()
        {
            if (VatCategory.IsZeroFPA(Model.vatCategory))
                if (!Model.vatExemptionCategory.HasValue)
                    AddPropertyError(nameof(Model.vatExemptionCategory), "Απαιτείται τιμή για το πεδίο όταν ο συντελεστής ΦΠΑ είναι 0% .");
        }
 
        /// <summary>
        /// Returns the model.
        /// </summary>
        public InvoiceRowType Model { get { return fModel as InvoiceRowType; } }
    }

}
