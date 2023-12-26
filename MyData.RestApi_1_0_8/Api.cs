namespace MyData.RestApi
{
 
    static public class Api
    {

        static public async Task<ResponseDoc> SendInvoices(string UserName, string UserKey, InvoicesDoc InvoiceList)
        {
            var Result = new ResponseDoc();

            await Task.CompletedTask;

            return Result;
        }
    }
}
