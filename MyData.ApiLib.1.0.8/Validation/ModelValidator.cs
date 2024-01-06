using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib.Validation
{
    /// <summary>
    /// Helper for validating MyData models just before an API call
    /// </summary>
    static public class ModelValidator
    {
        /*
        static public List<string> Validate()
        {
            List<string> ErrorList = new List<string>();
            return ErrorList;
        }  
        */
        static public bool IsValidCurrency(string Value)
        {
            return Enum.GetNames(typeof(CurrencyType)).Contains(Value);
        }

        static public void Validate(List<string> ErrorList, InvoiceHeaderType Model)
        {
            if (string.IsNullOrWhiteSpace(Model.series))
                ErrorList.Add("Δεν έχει οριστεί: Σειρ Παραστατικύ");

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
        static public void Validate(List<string> ErrorList, AadeBookInvoiceType Model)
        {
            // TODO: Validate InvoicesDoc
            if (Model.invoiceHeader == null)
            {
                ErrorList.Add("Δεν έχει οριστεί Header στο Παραστατικό.");
                return;
            }

            Validate(ErrorList, Model.invoiceHeader);
        }

        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(InvoicesDoc Model)
        {
            List<string> ErrorList = new List<string>();

            foreach (var Item in Model.invoice)
                Validate(ErrorList, Item);            

            return ErrorList;
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(IncomeClassificationsDoc Model)
        {
            List<string> ErrorList = new List<string>();

            // TODO: Validate IncomeClassificationsDoc

            return ErrorList;
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(ExpensesClassificationsDoc Model)
        {
            List<string> ErrorList = new List<string>();

            // TODO: Validate ExpensesClassificationsDoc

            return ErrorList;
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(PaymentMethodsDoc Model)
        {
            List<string> ErrorList = new List<string>();

            // TODO: Validate PaymentMethodsDoc

            return ErrorList;
        }
    }
}
