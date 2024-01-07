namespace MyData.ApiLib
{

    /// <summary>
    /// Helper for the MyData Api.
    /// <para>Contains calls for MyData Api HTTP calls.</para>
    /// </summary>
    static public class Api
    {
        /* private */
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
        static void AddQueryParam(StringBuilder SB, string Param, object Value)
        {
            if (!string.IsNullOrWhiteSpace(Param) && Value != null)
            {
                Type T = Value.GetType();

                string sValue = "";
                if (T == typeof(string) || T == typeof(int))
                {
                    sValue = Value.ToString();
                }
                else if (Value.GetType() == typeof(DateTime))
                {
                    sValue += ((DateTime)Value).ToString("dd/MM/yyyy");
                }

                if (!string.IsNullOrWhiteSpace(sValue))
                {
                    if (SB.Length > 0)
                        SB.Append("&");
                    SB.Append($"{Param}={sValue}");
                }
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

        /* public */
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
        /// <para>Αυτή η POST μέθοδος χρησιμοποιείται για την ακύρωση παραστατικού χωρίς επαναϋποβολή καινούργιου. </para>
        /// <para>Ο χρήστης την καλεί υποβάλλοντας ως παράμετρο το mark του παραστατικού το οποίο θέλει να ακυρώσει. </para>
        /// <para>Για την περίπτωση εκείνη και μόνο που η μέθοδος κληθεί από τρίτο πρόσωπο (όπως εκπρόσωπος Ν.Π. ή λογιστής), 
        /// ο ΑΦΜ της οντότητας που εξέδωσε το προς ακύρωση παραστατικό αποστέλλεται μέσω της παραμέτρου entityVatNumber, 
        /// διαφορετικά η εν λόγω παράμετρος δεν χρειάζεται να αποσταλλεί. </para>
        /// <para>Δεν απαιτείται αποστολή xml body.</para>
        /// </summary>
        static public async Task<ResponseDoc> CancelInvoice(string UserName, string UserKey, string Mark, string EntityVatNumber = null)
        {
            CheckIsInitialized();

            if (string.IsNullOrWhiteSpace(Mark))
                Throw("CancelInvoice: Cannot cancel an invoice. No Mark is specified");

            string ActionUrl = !string.IsNullOrWhiteSpace(EntityVatNumber) ? 
                                $"CancelInvoice?mark={Mark}&entityVatNumber={EntityVatNumber}" : 
                                $"CancelInvoice?mark={Mark}";

            ApiCall CI = await Client.PostAsync(UserName, UserKey, ActionUrl, null).ConfigureAwait(false);

            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            ResponseDoc Result = ApiXml.Deserialize<ResponseDoc>(CI.ResponseText);
            return Result;
        }


        /// <summary>
        /// Get invoices sent by other entities, concerning this entity or get invoices sent by this entity, concerning other entities. 
        /// </summary>
        /// <param name="UserName">Required. AADE User Id</param>
        /// <param name="UserKey">Required. AADE Subscription Key</param>
        /// <param name="EntityDocs">Required. When true requests documents send by this entiry, when false requests documents send by other entities</param>
        /// <param name="StartMark">Required. The AADE Mark. Returned documents have Mark greater than this parameter.</param>
        /// <param name="EndMark">Optional. Maximum Mark of documents to return.</param>
        /// <param name="InvoiceCategory">Optional. Invoice Category of documents to return</param>
        /// <param name="ReceiverVatNumber">Optional. VAT number of the other entity.</param>
        /// <param name="EntityVatNumber">Optional. VAT number of the sender entity. Required when the sender is a third party, e.g. an accountant.</param>
        /// <param name="DateFrom">Optional. Return documents having Date greater or equal to this parameter.</param>
        /// <param name="DateTo">Optional. Return documents having Date lesser or equal to this parameter.</param>
        /// <param name="NextPartitionKey">Optional. Used in getting paged results. Empty in the first call. Comes from the returned value of this call, <see cref="RequestedDoc.continuationToken"/></param>
        /// <param name="NextRowKey">Optional. Used in getting paged results. Empty in the first call. Comes from the returned value of this call, <see cref="RequestedDoc.continuationToken"/> </param>
        /// <returns></returns>
        static public async Task<RequestedDoc> RequestDocList(string UserName, string UserKey, 
                                                              bool EntityDocs,
                                                              string StartMark,
                                                              string EndMark = null,
                                                              InvoiceCategory InvoiceCategory = null,
                                                              string ReceiverVatNumber = null,
                                                              string EntityVatNumber = null,
                                                              DateTime? DateFrom = null,
                                                              DateTime? DateTo = null,
                                                              string NextPartitionKey = null,
                                                              string NextRowKey = null)
        /*
        // RequestDocs?             mark={mark}[&dateFrom][&dateTo][&entityVatNumber][&counterVatNumber][&invType][&maxMark][&nextPartitionKey][&nextRowKey]
        // RequestTransmittedDocs?  mark={mark}[&dateFrom][&dateTo][&entityVatNumber][&counterVatNumber][&invType][&maxMark][&nextPartitionKey][&nextRowKey]

        Parameter               Required    Description
        -------------------------------------------------------------------
        mark                    Ναι         Μοναδικός αριθμός καταχώρησης
        entityVatNumber         Όχι         ΑΦΜ οντότητας
        dateFrom                Όχι         Αρχή χρονικού διαστήματος αναζήτησης για την ημερομηνία έκδοσης
        dateTo                  Όχι         Τέλος χρονικού διαστήματος αναζήτησης για την ημερομηνία έκδοσης
        receiverVatNumber       Όχι         ΑΦΜ αντισυμβαλλόμενου   
        invType                 Όχι         Τύπος παραστατικού
        maxMark                 Όχι         Μέγιστος Αριθμός ΜΑΡΚ
        nextPartitionKey        Όχι         Παράμετρος για την τμηματική λήψη των αποτελεσμάτων
        nextRowKey              Όχι         Παράμετρος για την τμηματική λήψη των αποτελεσμάτων 

        1) Στην περίπτωση που τα αποτελέσματα αναζήτησης ξεπερνούν σε μέγεθος το μέγιστο επιτρεπτό όριο ο χρήστης θα τα λάβει τμηματικά. 
           Τα πεδία nextPartitionKey και nextRowKey θα εμπεριέχονται σε κάθε τμήμα των αποτελεσμάτων 
           και θα χρησιμοποιούνται ως παράμετροι στην κλήση για την λήψη του επόμενου τμήματος αποτελεσμάτων
        2) Σε περίπτωση που κάποια εκ των παραπάνω παραμέτρων δεν έχει τιμή, η αναζήτηση πραγματοποιείται 
           για όλες τις πιθανές τιμές αυτού του πεδίου, όπως προηγουμένως
        3) Σε περίπτωση που μόνο μια εκ των dateFrom, dateTo παραληφθεί, η αναζήτηση θα εκτελεστεί 
           μόνο για την ημερομηνία που έχει δοθεί στην άλλη παράμετρο. 
           Αν και οι παράμετροι έχουν τιμή, η αναζήτηση θα εκτελεστεί για το διάστημα από dateFrom έως dateTo.
        4) Εφόσον αποδοθεί τιμή στην παράμετρο maxMark, θα επιστραφούν όσες εγγραφές έχουν ΜΑΡΚ μικρότερο ή ίσο αυτή της τιμής
        5) Οι τιμές των παραμέτρων receiverVatNumber και invType εφαρμόζονται πάντα με τον συντελεστή ισότητας (equal operator)
        6) Στην παράμετρο invType δίνεται ως τιμή ο αριθμός που αντιστοιχεί στον συγκεκριμένο τύπο σύμφωνα με τον πίνακα 8.1 του Παραρτήματος
         */
        {

            CheckIsInitialized();

            if (string.IsNullOrWhiteSpace(StartMark))
                Throw("RequestDocList: Cannot Request Docs. No StartMark is specified");

            StringBuilder SB = new StringBuilder();
            SB.Append($"mark={StartMark}");
            AddQueryParam(SB, "maxMark",            EndMark);
            AddQueryParam(SB, "invType", InvoiceCategory == null ? null : InvoiceCategory.Value);
            AddQueryParam(SB, "entityVatNumber",    EntityVatNumber);
            AddQueryParam(SB, "receiverVatNumber", ReceiverVatNumber);
            AddQueryParam(SB, "dateFrom",           DateFrom);
            AddQueryParam(SB, "dateTo",             DateTo);
            AddQueryParam(SB, "nextPartitionKey",   NextPartitionKey);
            AddQueryParam(SB, "nextRowKey",         NextRowKey);

            string ActionUrl = EntityDocs ? "RequestTransmittedDocs" : "RequestDocs"; 
            if (SB.Length > 0)
                SB.Insert(0, "?");

            ActionUrl += SB.ToString();

            ApiCall CI = await Client.GetAsync(UserName, UserKey, ActionUrl).ConfigureAwait(false);

            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            RequestedDoc Result = ApiXml.Deserialize<RequestedDoc>(CI.ResponseText);
            return Result;
        }



        /// <summary>
        /// Returns information regarding Incomes or Expenses of the entity.
        /// <para></para>
        /// <para>Η κλήση επιστρέφει γραμμές με πληροφορίες για τα έσοδα του χρήστη, 
        /// για συγκεκριμένο ημερολογιακό κλειστό διάστημα που ορίζεται από τις τιμές των παραμέτρων dateFrom και dateTo. </para>
        ///  <para>Προαιρετικά η αναζήτηση μπορεί να πραγματοποιηθεί 
        /// με επιπλέον φίλτρα συγκεκριμένο ΑΦΜ αντισυμβαλλόμενου 
        /// και συγκεκριμένο τύπο παραστατικού.</para>
        /// </summary>
        /// <param name="UserName">Required.AADE User Id</param>
        /// <param name="UserKey">Required.AADE Subscription Key</param>
        /// <param name="Income">Required. When true returns the entity Incomes. When false returns the entity Expenses. </param>
        /// <param name="DateFrom">Required.  Return information having Date greater or equal to this parameter.</param>
        /// <param name="DateTo">Required.  Return documents having Date lesser or equal to this parameter.</param>
        /// <param name="CounterVatNumber">Optional. VAT number of the other entity.</param>
        /// <param name="EntityVatNumber">Optional. VAT number of the sender entity. Required when the sender is a third party, e.g. an accountant.</param>
        /// <param name="InvoiceCategory">Optional. Invoice Category of documents to return. </param>
        /// <param name="NextPartitionKey">Optional. Used in getting paged results. Empty in the first call. Comes from the returned value of this call, <see cref="RequestedDoc.continuationToken"/></param>
        /// <param name="NextRowKey">Optional. Used in getting paged results. Empty in the first call. Comes from the returned value of this call, <see cref="RequestedDoc.continuationToken"/> </param>
        /// <returns></returns>
        static async Task<RequestedBookInfo> RequestMyIncomeOrMyExpenses(string UserName, string UserKey,
                                                                         bool Income,
                                                                         DateTime? DateFrom = null,
                                                                         DateTime? DateTo = null,
                                                                         string CounterVatNumber = null,
                                                                         string EntityVatNumber = null,
                                                                         InvoiceCategory InvoiceCategory = null,
                                                                         string NextPartitionKey = null,
                                                                         string NextRowKey = null)
        {
            /*
            // https://mydatapi.aade.gr/myDATA/RequestMyIncome?  [dateFrom]&[dateTo]&[counterVatNumber]&[entityVatNumber]&[invType]&[nextPartitionKey]&[nextRowKey]
            // https://mydataapidev.aade.gr/ RequestMyExpenses?  [dateFrom]&[dateTo]&[counterVatNumber]&[entityVatNumber]&[invType]&[nextPartitionKey]&[nextRowKey]

            Όνομα Παραμέτρου            Υποχρεωτικό     Περιγραφή
            -------------------------------------------------------------------
            dateFrom                    Ναι             Ημερομηνία Από
            dateTo                      Ναι             Ημερομηνία Έως 
            counterVatNumber            Όχι             ΑΦΜ αντισυμβαλλόμενου 
            entityVatNumber             Όχι             ΑΦΜ αναφοράς 
            invType                     Όχι             Τύπος Παραστατικού
            nextPartitionKey            Όχι             Παράμετρος για την τμηματική λήψη των αποτελεσμάτων
            nextRowKey                  Όχι             Παράμετρος για την τμηματική λήψη των αποτελεσμάτων
 
            1) Αν η παράμετρος entityVatNumber έχει τιμή, η αναζήτηση θα πραγματοποιηθεί για αυτόν τον ΑΦΜ, 
               αλλιώς για τον ΑΦΜ του χρήστη που καλεί την μέθοδο 
            2) Οι παράμετροι ημερομηνιών πρέπει να εισαχθούν με format dd/MM/yyyy
            3) Όταν μια προαιρετική παράμετρος δεν εισάγεται, η αναζήτηση πραγματοποιείται 
               για όλες τις πιθανές τιμές που θα μπορούσε να έχει αυτό το πεδίο
            4) Στην περίπτωση που τα αποτελέσματα αναζήτησης ξεπερνούν σε μέγεθος το μέγιστο επιτρεπτό όριο 
               ο χρήστης θα τα λάβει τμηματικά. 
               Τα πεδία nextPartitionKey και nextRowKey θα εμπεριέχονται σε κάθε τμήμα των αποτελεσμάτων 
               και θα χρησιμοποιούνται ως παράμετροι στην κλήση για την λήψη του επόμενου τμήματος αποτελεσμάτων
             */

 
            CheckIsInitialized();

            StringBuilder SB = new StringBuilder();
            AddQueryParam(SB, "dateFrom", DateFrom);
            AddQueryParam(SB, "dateTo", DateTo);
            AddQueryParam(SB, "counterVatNumber", CounterVatNumber);
            AddQueryParam(SB, "entityVatNumber", EntityVatNumber);
            AddQueryParam(SB, "invType", InvoiceCategory == null ? null : InvoiceCategory.Value);
            AddQueryParam(SB, "nextPartitionKey", NextPartitionKey);
            AddQueryParam(SB, "nextRowKey", NextRowKey);

            string ActionUrl = Income ? "RequestMyIncome" : "RequestMyExpenses";
            if (SB.Length > 0)
                SB.Insert(0, "?");
            ActionUrl += SB.ToString();

            ApiCall CI = await Client.GetAsync(UserName, UserKey, ActionUrl).ConfigureAwait(false);

            if (!CI.IsSuccess)
                Throw(CI.ReasonPhrase);

            RequestedBookInfo Result = ApiXml.Deserialize<RequestedBookInfo>(CI.ResponseText);
            return Result;
        }

        /* private */
        /// <summary>
        /// True indicates that this class is initialized.
        /// </summary>
        static public bool IsInitialized { get; private set; }
    }
}
