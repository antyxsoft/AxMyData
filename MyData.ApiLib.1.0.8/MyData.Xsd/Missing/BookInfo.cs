using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Xsd
{

    [System.SerializableAttribute()]
    public partial class BookInfo
    {
        /*
        Πεδίο                   Τύπος                   Υποχρεωτικό         Περιγραφή
        -----------------------------------------------------------------------------------------
        continuationToken       continuationTokenType   Όχι                 Στοιχείο για την τμηματική λήψη αποτελεσμάτων 
        counterVatNumber        xs:string               Όχι                 ΑΦΜ λήπτη 
        issueDate               xs:date                 Ναι                 Ημερομηνία έκδοσης Παραστατικού
        invType                 xs:string               Ναι                 Τύπος Παραστατικού
        selfpricing             xs:bool                 Όχι                 Αυτοτιμολόγηση
        invoiceDetailType       xs:int                  Όχι                 Επισήμανση
        netValue                xs:double               Όχι                 Καθαρή αξία
        vatAmount               xs:double               Όχι                 Ποσό ΦΠΑ
        withheldAmount          xs:double               Όχι                 Ποσό Παρακράτησης Φόρου
        otherTaxesAmount        xs:double               Όχι                 Ποσό Λοιπών Φόρων
        stampDutyAmount         xs:double               Όχι                 Ποσό Χαρτοσήμου
        feesAmount              xs:double               Όχι                 Ποσό Τελών
        deductionsAmount        xs:double               Όχι                 Ποσό Κρατήσεων
        thirdPartyAmount        xs:double               Όχι                 Ποσό Περί Τρίτων
        grossValue              xs:double               Όχι                 Συνολική Αξία
        count                   xs:int                  Ναι                 Πλήθος
        minMark                 xs:string               Όχι                 Ελάχιστο ΜΑΡΚ πλήθους
        maxMark                 xs:string               Όχι                 Μέγιστο ΜΑΡΚ πλήθους 
         */
        public BookInfo()
        {
        }

        public ContinuationTokenType continuationToken = new ContinuationTokenType();
        public string counterVatNumber;
        public DateTime issueDate = DateTime.MinValue;
        public string invType;
        public bool selfpricing;
        public int invoiceDetailType;
        public double netValue;
        public double vatAmount;
        public double withheldAmount;
        public double otherTaxesAmount;
        public double stampDutyAmount;
        public double feesAmount;
        public double deductionsAmount;
        public double thirdPartyAmount;
        public double grossValue;
        public int count;
        public string minMark;
        public string maxMark;


    }
}
