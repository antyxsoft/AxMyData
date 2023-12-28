using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Xsd
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

        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(InvoicesDoc Model)
        {
            List<string> ErrorList = new List<string>();

            // TODO: Validate InvoicesDoc

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
