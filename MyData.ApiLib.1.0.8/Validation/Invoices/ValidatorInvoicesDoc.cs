using System.Reflection;

namespace MyData.ApiLib
{
    /*
    static public class InvoicesValidator
    {   
        static public void Validate(List<string> ErrorList, InvoiceHeaderType Model)
        {
            if (string.IsNullOrWhiteSpace(Model.series))
                ErrorList.Add("Δεν έχει οριστεί: Σειρά παραστατικού");

            if (string.IsNullOrWhiteSpace(Model.aa))
                ErrorList.Add("Δεν έχει οριστεί: ΑΑ Παραστατικού");

            if (Model.issueDate == DateTime.MinValue)
                ErrorList.Add("Δεν έχει οριστεί: Ημ. Έκδοσης Παραστατικού");

            if (!InvoiceCategory.Exists(Model.invoiceType))
                ErrorList.Add("Δεν έχει οριστεί: ΑΑ Παραστατικού");

            //if (!string.IsNullOrWhiteSpace(Model.currency) && !IsValidCurrency(Model.currency))
            //    ErrorList.Add("Μη έγκυρη τιμή: Νόμισμα");

            if (Model.exchangeRate < 0)
                ErrorList.Add("Μη έγκυρη τιμή: Ισοτιμία");
        }


        static public void Validate(List<string> ErrorList, InvoicesDoc Model)
        {
            ModelValidator.ValidateModel(ErrorList, Model);
        }
    }


 
 
    */

 

    public class ValidatorInvoicesDoc : Validator
    {
        public ValidatorInvoicesDoc()
            : base(typeof(InvoicesDoc))
        {
        }
        public override void Validate(object Model, object ParentModel, List<string> ErrorList)
        {
            Validate(Model as InvoicesDoc, ParentModel, ErrorList);
        }

        void Validate(InvoicesDoc Model, object ParentModel, List<string> ErrorList)
        { 
            Validators.ValidatePropertiesByAttributes(Model, ErrorList); 
        }
    }














}
