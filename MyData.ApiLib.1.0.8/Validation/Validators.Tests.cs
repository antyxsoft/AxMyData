using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MyData.ApiLib
{
    /// <summary>
    /// Helper for validating MyData models just before an API call
    /// </summary>
    public static partial class Validators
    {
        const string SLine = "--------------------------------------------------------";
        static public JsonSerializerOptions JsonOptions = new JsonSerializerOptions() { WriteIndented = true };

        static void AddToResult(StringBuilder sbResults, List<string> ErrorList)
        {
            if (ErrorList.Count > 0)
            {
                foreach (string Error in ErrorList)
                {
                    sbResults.AppendLine(Error);
                }
            }
 
        }

        static void TestEmptyInvoices(StringBuilder sbResults)
        {
            string JsonText;
            List<string> ErrorList;
            InvoicesDoc Invoices;

            sbResults.AppendLine($"TEST MODEL: {GetTypeDescription(typeof(InvoicesDoc))}");
            sbResults.AppendLine(SLine);

            //*
            sbResults.AppendLine($"TEST NAME: No Invoice List");
            sbResults.AppendLine(SLine);
            Invoices = Models.CreateInvoicesDoc();
            Invoices.invoice = null;
            ErrorList = Validate(Invoices);
            AddToResult(sbResults, ErrorList);
            JsonText = JsonSerializer.Serialize(Invoices, JsonOptions);
            sbResults.AppendLine(JsonText);
            sbResults.AppendLine(SLine);
            //*/    
 
            sbResults.AppendLine($"TEST NAME: Empty Invoice List");
            sbResults.AppendLine(SLine);
            Invoices = Models.CreateInvoicesDoc();
            ErrorList = Validate(Invoices);
            AddToResult(sbResults, ErrorList);
            JsonText = JsonSerializer.Serialize(Invoices, JsonOptions);
            sbResults.AppendLine(JsonText);
            sbResults.AppendLine(SLine);

            //*
            sbResults.AppendLine($"TEST NAME: Empty Invoice");
            sbResults.AppendLine(SLine);
            Invoices = Models.CreateInvoicesDoc();
            AadeBookInvoiceType Invoice = Models.CreateAadeBookInvoiceType(true);
            Invoices.invoice.Add(Invoice);
            Invoice.transmissionFailure = 8;
            ErrorList = Validate(Invoices);
            AddToResult(sbResults, ErrorList);
            JsonText = JsonSerializer.Serialize(Invoices, JsonOptions);
            sbResults.AppendLine(JsonText);
            sbResults.AppendLine(SLine);
            //*/

            //sbResults.AppendLine(SLine);
            //sbResults.AppendLine($"TEST: {GetTypeDescription(typeof(AadeBookInvoiceType))}");
            //sbResults.AppendLine($"TEST NAME: Invoice");
        }
        static void TestInvoice(StringBuilder sbResults)
        {
            string JsonText;
            List<string> ErrorList;

            sbResults.AppendLine($"TEST: {GetTypeDescription(typeof(InvoicesDoc))}");
            sbResults.AppendLine($"TEST NAME: Invoice");

            InvoicesDoc Invoices = Models.CreateInvoicesDoc();
            AadeBookInvoiceType Invoice = Models.CreateAadeBookInvoiceType();
            Invoices.invoice.Add(Invoice);

            //Invoice


            ErrorList = Validate(Invoices);
            AddToResult(sbResults, ErrorList);
            JsonText = JsonSerializer.Serialize(Invoices, JsonOptions);
            sbResults.AppendLine(JsonText);
        }


        /* tests */
        static public string Test()
        {            
            StringBuilder SB = new StringBuilder();
            SB.AppendLine("MODEL VALIDATION");
            SB.AppendLine(SLine);
 
            TestEmptyInvoices(SB);

            return SB.ToString();

        }
    }
}
