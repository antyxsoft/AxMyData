using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib
{
    /// <summary>
    /// A context class used in validation.
    /// <para>An instance of this class is passed in the constructor of each <see cref="Validator"/> in a validation procedure</para>
    /// </summary>
    public class ValidatorContext
    {
        /* construction */
        /// <summary>
        /// Constructor.
        /// <para>A context instance records the Top Model, e.g. <see cref="InvoicesDoc"/>, for which the validation is executed. </para>
        /// </summary>
        public ValidatorContext(object TopModel)
        {
            Type ModelType = TopModel.GetType();

            if (ModelType == typeof(InvoicesDoc))
                Invoices = TopModel as InvoicesDoc;
            else if (ModelType == typeof(IncomeClassificationsDoc))
                IncomeClassifications = TopModel as IncomeClassificationsDoc;
            else if (ModelType == typeof(ExpensesClassificationsDoc))
                ExpensesClassifications = TopModel as ExpensesClassificationsDoc;
            else if (ModelType == typeof(PaymentMethodsDoc))
                PaymentMethods = TopModel as PaymentMethodsDoc;
        }

        /* public */
        /// <summary>
        /// Returns true if a specified model instance is a top-model.
        /// <para>A Top Model contains a list of sub-models, e.g. the <see cref="InvoicesDoc"/> contains a list of <see cref="AadeBookInvoiceType"/> items. </para>
        /// </summary>
        static public bool IsTopModel(object TopModel)
        {
            Type ModelType = TopModel.GetType();

            return ModelType == typeof(InvoicesDoc)
                || ModelType == typeof(IncomeClassificationsDoc)
                || ModelType == typeof(ExpensesClassificationsDoc)
                || ModelType == typeof(PaymentMethodsDoc);
        }
        /// <summary>
        /// Returns true if a specified model instance is a sub-model.
        /// <para>A Top Model contains a list of sub-models, e.g. the <see cref="InvoicesDoc"/> contains a list of <see cref="AadeBookInvoiceType"/> items. </para>
        /// </summary>
        static public bool IsSubModel(object SubModel)
        {
            Type ModelType = SubModel.GetType();

            return ModelType == typeof(AadeBookInvoiceType)
                || ModelType == typeof(InvoiceIncomeClassificationType)
                || ModelType == typeof(InvoiceExpensesClassificationType)
                || ModelType == typeof(PaymentMethodType); 
        }
      
        /// <summary>
        /// Sets the proper sub-model.
        /// <para>Each Top Model contains a list of sub-models, e.g. the <see cref="InvoicesDoc"/> contains list of <see cref="AadeBookInvoiceType"/> items. </para>
        /// </summary>
        public void SetSubModel(object SubModel)
        {
            if (IsSubModel(SubModel))
            {
                Invoice = null;
                InvoiceIncomeClassification = null;
                InvoiceExpensesClassification = null;
                PaymentMethod = null;

                Type ModelType = SubModel.GetType();

                if (ModelType == typeof(AadeBookInvoiceType))
                    Invoice = SubModel as AadeBookInvoiceType;
                else if (ModelType == typeof(InvoiceIncomeClassificationType))
                    InvoiceIncomeClassification = SubModel as InvoiceIncomeClassificationType;
                else if (ModelType == typeof(InvoiceExpensesClassificationType))
                    InvoiceExpensesClassification = SubModel as InvoiceExpensesClassificationType;
                else if (ModelType == typeof(PaymentMethodType))
                    PaymentMethod = SubModel as PaymentMethodType;
            }
        }

        /* top-model properties */
        /// <summary>
        /// The <see cref="InvoicesDoc"/> top-model.
        /// <para>The <see cref="InvoicesDoc"/> is the top-model. It contains a list of <see cref="AadeBookInvoiceType"/> sub-model items.</para>
        /// </summary>
        public InvoicesDoc Invoices { get; }
        /// <summary>
        /// The <see cref="IncomeClassificationsDoc"/> top-model.
        /// <para>The <see cref="IncomeClassificationsDoc"/> is the top-model. It contains a list of <see cref="InvoiceIncomeClassificationType"/> sub-model items.</para>
        /// </summary>
        public IncomeClassificationsDoc IncomeClassifications { get; }
        /// <summary>
        /// The <see cref="ExpensesClassificationsDoc"/> top-model.
        /// <para>The <see cref="ExpensesClassificationsDoc"/> is the top-model. It contains a list of <see cref="InvoiceExpensesClassificationType"/> sub-model items.</para>
        /// </summary>
        public ExpensesClassificationsDoc ExpensesClassifications { get; }
        /// <summary>
        /// The <see cref="PaymentMethodsDoc"/> top-model.
        /// <para>The <see cref="PaymentMethodsDoc"/> is the top-model. It contains a list of <see cref="PaymentMethodType"/> sub-model items.</para>
        /// </summary>
        public PaymentMethodsDoc PaymentMethods { get; }

        /* sub-model properties */
        /// <summary>
        /// The <see cref="AadeBookInvoiceType"/> sub-model.
        /// <para>The <see cref="InvoicesDoc"/> is the top-model. It contains a list of <see cref="AadeBookInvoiceType"/> sub-model items.</para>
        /// </summary>
        public AadeBookInvoiceType Invoice { get; private set; }
        /// <summary>
        /// The <see cref="InvoiceIncomeClassificationType"/> sub-model.
        /// <para>The <see cref="IncomeClassificationsDoc"/> is the top-model. It contains a list of <see cref="InvoiceIncomeClassificationType"/> sub-model items.</para>
        /// </summary>
        public InvoiceIncomeClassificationType InvoiceIncomeClassification { get; private set; }
        /// <summary>
        /// The <see cref="InvoiceExpensesClassificationType"/> sub-model.
        /// <para>The <see cref="ExpensesClassificationsDoc"/> is the top-model. It contains a list of <see cref="InvoiceExpensesClassificationType"/> sub-model items.</para>
        /// </summary>
        public InvoiceExpensesClassificationType InvoiceExpensesClassification { get; private set; }
        /// <summary>
        /// The <see cref="PaymentMethodType"/> sub-model.
        /// <para>The <see cref="PaymentMethodsDoc"/> is the top-model. It contains a list of <see cref="PaymentMethodType"/> sub-model items.</para>
        /// </summary>
        public PaymentMethodType PaymentMethod { get; private set; }

        /* misc properties */
        /// <summary>
        /// A list of strings.
        /// <para>Validators add error messages to this list while validating models, during a validation procedure.</para>
        /// </summary>
        public List<string> ErrorList { get; } = new List<string>();
        /// <summary>
        /// Not used. It could carry any shared information during a validation procedure.
        /// </summary>
        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();
        
    }
}
