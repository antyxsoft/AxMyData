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
        /// <param name="IsDeliveryDocumentToo">True οταν είναι Δελτίο Αποστολής ή Τιμολόγιο + Δελτίο Αποστολής</param>
        static public AadeBookInvoiceType CreateAadeBookInvoiceType(bool IsDeliveryDocumentToo = false)
        {
            AadeBookInvoiceType Result = new AadeBookInvoiceType();
            Result.invoiceHeader = new InvoiceHeaderType();
            Result.invoiceDetails = new List<InvoiceRowType>();
            Result.invoiceSummary = new InvoiceSummaryType();

            if (IsDeliveryDocumentToo)
                Result.invoiceHeader.otherDeliveryNoteHeader = CreateDeliveryNoteHeader();   

            return Result;
        }
        /// <summary>
        /// Creates and returns an <see cref="OtherDeliveryNoteHeaderType"/> along with its <see cref="AddressType"/> address.
        /// <para>Used as value to <see cref="AadeBookInvoiceType"/>.<see cref="InvoiceHeaderType.otherDeliveryNoteHeader"/> property.</para>
        /// </summary>
        static public OtherDeliveryNoteHeaderType CreateDeliveryNoteHeader()
        {
            OtherDeliveryNoteHeaderType Result = new OtherDeliveryNoteHeaderType();
            Result.loadingAddress = new AddressType();
            Result.deliveryAddress = new AddressType();
            return Result;
        }
    }
}
