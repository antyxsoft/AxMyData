using System.Collections.Generic;

namespace MyData.RestApi
{
 
    /// <summary>
    /// Helper for the MyData Api.
    /// <para>Contains calls for MyData Api HTTP calls.</para>
    /// </summary>
    static public class Api
    {

        static ApiClient Client;

        static void Throw(string Message)
        {
            throw new ApplicationException(Message);
        }
        static void CheckErrors(List<string> ErrorList)
        {
            if (ErrorList != null && ErrorList.Count > 0)
            {
                StringBuilder SB = new StringBuilder();
                foreach (var S in ErrorList)
                    SB.AppendLine(S);
                Throw(SB.ToString());
            }
        }
        static void CheckIsInitialized()
        {
            if (!IsInitialized)
            {
                Throw("AADE Api Client is not initialized. Call Api.Initialize() first");
            }
        }
        
        static void Client_OnAfter(object sender, ApiCall e)
        {
        }
        static void Client_OnBefore(object sender, ApiCall e)
        {
        }
        static void Client_OnError(object sender, ApiCall e)
        {
        }


        /// <summary>
        /// Initializes this class. Must be called before any other call.
        /// </summary>
        static public void Initialize(string BaseUrl)
        {
            if (!IsInitialized)
            {
                Client = new ApiClient(BaseUrl);

                Client.OnError += Client_OnError;
                Client.OnBefore += Client_OnBefore;
                Client.OnAfter += Client_OnAfter;
                
                IsInitialized = true;
            }
        }

        //await Task.CompletedTask;


        /// <summary>
        /// Sends a single invoice and returns the MyData response
        /// </summary>
        static public async Task<ResponseDoc> SendInvoice(string UserName, string UserKey, AadeBookInvoiceType Invoice)
        {
            InvoicesDoc List = new InvoicesDoc();
            List.invoice.Add(Invoice);
            ResponseDoc Result = await SendInvoiceList(UserName, UserKey, List).ConfigureAwait(false);
            return Result;
        }
        /// <summary>
        /// Sends a list of invoice items and returns the MyData response.
        /// <para>διαδικασία υποβολής ενός ή περισσότερων παραστατικών, συμπεριλαμβανομένων και διορθωμένων/τροποποιητικών</para>
        /// </summary>
        static public async Task<ResponseDoc> SendInvoiceList(string UserName, string UserKey, InvoicesDoc List)
        {
            CheckIsInitialized();
            CheckErrors(ModelValidator.Validate(List));
            string ActionUrl = "SendInvoices";

            ApiCall CI = await Client.PostAsync(UserName, UserKey, ActionUrl, List).ConfigureAwait(false);
            
            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            ResponseDoc Result = ApiXml.Deserialize<ResponseDoc>(CI.ResponseText);
            return Result;
        }

        /// <summary>
        /// Sends a single income classification and returns the MyData response
        /// </summary>
        static public async Task<ResponseDoc> SendIncomeClassification(string UserName, string UserKey, InvoiceIncomeClassificationType Classification)
        {
            IncomeClassificationsDoc List = new IncomeClassificationsDoc();
            List.incomeInvoiceClassification.Add(Classification);
            ResponseDoc Result = await SendIncomeClassificationList(UserName, UserKey, List).ConfigureAwait(false);
            return Result;
        }
        /// <summary>
        /// Sends a list of income classification items and returns the MyData response
        /// <para>διαδικασία υποβολής χαρακτηρισμών εσόδων, ενός ή περισσότερων, που θα αντιστοιχούν σε ήδη υποβεβλημένα παραστατικά</para>
        /// </summary>
        static public async Task<ResponseDoc> SendIncomeClassificationList(string UserName, string UserKey, IncomeClassificationsDoc List)
        {
            CheckIsInitialized();
            CheckErrors(ModelValidator.Validate(List));
            string ActionUrl = "SendIncomeClassification";

            ApiCall CI = await Client.PostAsync(UserName, UserKey, ActionUrl, List).ConfigureAwait(false);

            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            ResponseDoc Result = ApiXml.Deserialize<ResponseDoc>(CI.ResponseText);
            return Result;
        }
 
        /// <summary>
        /// Sends a single expense classification and returns the MyData response
        /// </summary>
        static public async Task<ResponseDoc> SendExpenseClassification(string UserName, string UserKey, InvoiceExpensesClassificationType Classification)
        {
            ExpensesClassificationsDoc List = new ExpensesClassificationsDoc();
            List.expensesInvoiceClassification.Add(Classification);
            ResponseDoc Result = await SendExpenseClassificationList(UserName, UserKey, List).ConfigureAwait(false);
            return Result;
        }
        /// <summary>
        /// Sends a list of expense classification items and returns the MyData response
        /// <para>διαδικασία υποβολής χαρακτηρισμών εξόδων, ενός ή περισσότερων, που θα αντιστοιχούν σε ήδη υποβεβλημένα παραστατικά</para>
        /// </summary>
        static public async Task<ResponseDoc> SendExpenseClassificationList(string UserName, string UserKey, ExpensesClassificationsDoc List)
        {
            CheckIsInitialized();
            CheckErrors(ModelValidator.Validate(List));
            string ActionUrl = "SendExpensesClassification";

            ApiCall CI = await Client.PostAsync(UserName, UserKey, ActionUrl, List).ConfigureAwait(false);

            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            ResponseDoc Result = ApiXml.Deserialize<ResponseDoc>(CI.ResponseText);
            return Result;
        }

        /// <summary>
        /// Sends a single payment method and returns the MyData response
        /// </summary>
        static public async Task<ResponseDoc> SendPaymentMethod(string UserName, string UserKey, PaymentMethodType Invoice)
        {
            PaymentMethodsDoc List = new PaymentMethodsDoc();
            List.paymentMethods.Add(Invoice);
            ResponseDoc Result = await SendPaymentMethodList(UserName, UserKey, List).ConfigureAwait(false);
            return Result;
        }
        /// <summary>
        /// Sends a list of payment method items and returns the MyData response
        /// <para>διαδικασία υποβολής ενός ή περισσότερων τρόπων πληρωμής, που θα αντιστοιχηθούν σε ήδη υποβεβλημένα παραστατικά</para>
        /// </summary>
        static public async Task<ResponseDoc> SendPaymentMethodList(string UserName, string UserKey, PaymentMethodsDoc List)
        {
            CheckIsInitialized();
            CheckErrors(ModelValidator.Validate(List));
            string ActionUrl = "SendPaymentsMethod";

            ApiCall CI = await Client.PostAsync(UserName, UserKey, ActionUrl, List).ConfigureAwait(false);

            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            ResponseDoc Result = ApiXml.Deserialize<ResponseDoc>(CI.ResponseText);
            return Result;
        }

        /// <summary>
        /// Cancels a previously sent invoice specified by its mark.
        /// </summary>
        static public async Task<ResponseDoc> CancelInvoice(string UserName, string UserKey, string Mark, string EntityVatNumber = null)
        {
            CheckIsInitialized();

            if (string.IsNullOrWhiteSpace(Mark))
                Throw("Can not cancel an invoice. No Mark is specified");

            string ActionUrl = !string.IsNullOrWhiteSpace(EntityVatNumber) ? 
                                $"CancelInvoice?mark={Mark}&entityVatNumber={EntityVatNumber}" : 
                                $"CancelInvoice?mark={Mark}";

            ApiCall CI = await Client.PostAsync(UserName, UserKey, ActionUrl, null).ConfigureAwait(false);

            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            ResponseDoc Result = ApiXml.Deserialize<ResponseDoc>(CI.ResponseText);
            return Result;
        }

        // RequestDocs?mark={mark}[&dateFrom][&dateTo][&entityVatNumber][&counterVatNumber][&invType][&maxMark][&nextPartitionKey][&nextRowKey]

        static public async Task<RequestedDoc> RequestDocList(string UserName, string UserKey)
        {
            RequestedDoc Result = null;
            return Result;
        }

        /* private */
        /// <summary>
        /// True indicates that this class is initialized.
        /// </summary>
        static public bool IsInitialized { get; private set; }
    }
}
