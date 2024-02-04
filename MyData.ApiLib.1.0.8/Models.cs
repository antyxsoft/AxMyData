using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib
{
    /// <summary>
    /// Helper class for working with MyData models
    /// </summary>
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
        /// Adds and returns a <see cref="TaxTotalsType"/> to <see cref="AadeBookInvoiceType.taxesTotals"/> list.
        /// <para>NOTE: Nullable values are optional.</para>
        /// </summary>
        static public TaxTotalsType AddTaxTotalsLine(this AadeBookInvoiceType Invoice, TaxType TaxType, decimal TaxAmount, decimal? UnderlyingValue = null, int? TaxCategory = null)
        {
            if (Invoice.taxesTotals == null)
                Invoice.taxesTotals = new List<TaxTotalsType>();

            TaxTotalsType Result = new TaxTotalsType();
            Invoice.taxesTotals.Add(Result);

            Result.id = Convert.ToSByte(Invoice.taxesTotals.Count);
            Result.taxType = Convert.ToSByte(TaxType.Value);   
            Result.taxAmount = TaxAmount;
            if (UnderlyingValue.HasValue)
                Result.underlyingValue = UnderlyingValue.Value;
            if (TaxCategory.HasValue)
                Result.taxCategory = TaxCategory.Value;

            return Result;
        }

        /* Income Classification */
        /// <summary>
        /// Creates and returns an <see cref="IncomeClassificationType"/>.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType CreateIncomeClassification(IncomeCategory Category, decimal Amount, IncomeValue IncomeValue = null)
        {
            return CreateIncomeClassification(Category.Value, Amount, IncomeValue != null ? IncomeValue.Value : null);
        }
        /// <summary>
        /// Creates and returns an <see cref="IncomeClassificationType"/>.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType CreateIncomeClassification(IncomeClassificationCategoryType Category, decimal Amount, IncomeClassificationValueType? IncomeValue)
        {
            IncomeClassificationType Result = new IncomeClassificationType();
            Result.classificationCategory = Category;
            Result.amount = Amount;
            if (IncomeValue.HasValue)
                Result.classificationType = IncomeValue.Value;

            return Result;
        }

        static IncomeClassificationType AddLine(this List<IncomeClassificationType> List, IncomeCategory Category, decimal Amount, IncomeValue IncomeValue = null)
        {
            IncomeClassificationType Result = List.AddLine(Category.Value, Amount, IncomeValue != null ? IncomeValue.Value : null);
            return Result;
        }
        static IncomeClassificationType AddLine(this List<IncomeClassificationType> List, IncomeClassificationCategoryType Category, decimal Amount, IncomeClassificationValueType? IncomeValue)
        {
            IncomeClassificationType Result = CreateIncomeClassification(Category, Amount, IncomeValue);
            Result.id = Convert.ToSByte(List.Count);
            return Result;
        }
 

        /// <summary>
        /// Creates and adds an <see cref="IncomeClassificationType"/> to a <see cref="InvoiceRowType.incomeClassification"/> list.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType AddIncomeLine(this InvoiceRowType Container, IncomeCategory Category, decimal Amount, IncomeValue IncomeValue = null)
        {
            IncomeClassificationType Result = Container.AddIncomeLine(Category.Value, Amount, IncomeValue != null ? IncomeValue.Value : null);
            return Result;
        }
        /// <summary>
        /// Creates and adds an <see cref="IncomeClassificationType"/> to a <see cref="InvoiceRowType.incomeClassification"/> list.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType AddIncomeLine(this InvoiceRowType Container, IncomeClassificationCategoryType Category, decimal Amount, IncomeClassificationValueType? IncomeValue)
        {
            if (Container.incomeClassification == null)
                Container.incomeClassification = new List<IncomeClassificationType>();

            IncomeClassificationType Result = Container.incomeClassification.AddLine(Category, Amount, IncomeValue);
            return Result;
        }

        /// <summary>
        /// Creates and adds an <see cref="IncomeClassificationType"/> to a <see cref="InvoiceSummaryType.incomeClassification"/> list.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType AddIncomeLine(this InvoiceSummaryType Container, IncomeCategory Category, decimal Amount, IncomeValue IncomeValue = null)
        {
            IncomeClassificationType Result = Container.AddIncomeLine(Category.Value, Amount, IncomeValue != null ? IncomeValue.Value : null);
            return Result;
        }
        /// <summary>
        /// Creates and adds an <see cref="IncomeClassificationType"/> to a <see cref="InvoiceSummaryType.incomeClassification"/> list.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType AddIncomeLine(this InvoiceSummaryType Container, IncomeClassificationCategoryType Category, decimal Amount, IncomeClassificationValueType? IncomeValue)
        {
            if (Container.incomeClassification == null)
                Container.incomeClassification = new List<IncomeClassificationType>();

            IncomeClassificationType Result = Container.incomeClassification.AddLine(Category, Amount, IncomeValue);
            return Result;
        } 

        /// <summary>
        /// Creates and adds an <see cref="IncomeClassificationType"/> to a <see cref="InvoicesIncomeClassificationDetailType.incomeClassificationDetailData"/> list.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType AddIncomeLine(this InvoicesIncomeClassificationDetailType Container, IncomeCategory Category, decimal Amount, IncomeValue IncomeValue = null)
        {
            IncomeClassificationType Result = Container.AddIncomeLine(Category.Value, Amount, IncomeValue != null ? IncomeValue.Value : null);
            return Result;
        }
        /// <summary>
        /// Creates and adds an <see cref="IncomeClassificationType"/> to a <see cref="InvoicesIncomeClassificationDetailType.incomeClassificationDetailData"/> list.
        /// <para>NOTE: Nullable and null values are optional.</para>
        /// </summary>
        static public IncomeClassificationType AddIncomeLine(this InvoicesIncomeClassificationDetailType Container, IncomeClassificationCategoryType Category, decimal Amount, IncomeClassificationValueType? IncomeValue)
        {
            if (Container.incomeClassificationDetailData == null)
                Container.incomeClassificationDetailData = new List<IncomeClassificationType>();


            IncomeClassificationType Result = Container.incomeClassificationDetailData.AddLine(Category, Amount, IncomeValue);
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
