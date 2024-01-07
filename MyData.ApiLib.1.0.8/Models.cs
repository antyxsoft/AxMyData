using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib
{
    static public class Models
    {

        /// <summary>
        /// Creates and returns a model having created all properties decorated with the <see cref="RequiredAttribute"/> that are objects of lists .
        /// <para>CAUTION: This function creates only the required properties. Non required should be created by the caller.</para>
        /// </summary>
        static public InvoicesDoc CreateInvoicesDoc()
        {
            InvoicesDoc Result = new InvoicesDoc();
            Result.invoice = new List<AadeBookInvoiceType>();
            return Result;
        }
        /// <summary>
        /// Creates and returns a model having created all properties decorated with the <see cref="RequiredAttribute"/> that are objects of lists .
        /// <para>CAUTION: This function creates only the required properties. Non required should be created by the caller.</para>
        /// </summary>
        static public AadeBookInvoiceType CreateAadeBookInvoiceType()
        {
            AadeBookInvoiceType Result = new AadeBookInvoiceType();
            Result.invoiceHeader = new InvoiceHeaderType();
            Result.invoiceDetails = new List<InvoiceRowType>();
            Result.invoiceSummary = new InvoiceSummaryType();

            return Result;
        }
    }
}
