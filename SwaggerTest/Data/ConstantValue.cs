using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;
//using Interop.QBXMLRP2;

namespace SwaggerTest.Data
{
    public class ConstantValue
    {

/*        public static String getConfigurationGroup(String name)
        {
            var PostSetting = ConfigurationManager.GetSection("BlogGroup/PostSetting") as NameValueCollection;
            return PostSetting[name];

        }
*/
//		public string QBFILEPATH = getConfigurationGroup("QbFilePath");
//        public string QBFILEPATH = "C:\\Users\\Public\\Documents\\Intuit\\QuickBooks\\Company Files\\";
//        public string QBFILEPATH = "C:\\test\\";
//        public string QBFILEPATH = "C:\\Users\\Public\\Documents\\Intuit\\QuickBooks\\Sample Company Files\\QuickBooks Enterprise Solutions 17.0\\";
//        public string QBFILENAME = "Delight.QBW";
//        public string QBFILENAME = "MF 2014.QBW";
//        public string QBFILENAME = getConfigurationGroup("QbFileName");
        public string QBFILENAME = "MF.QBW";

        //        public string QBFILENAME = "Sample_Enterprise_Professional.QBW";
//        public QBFileMode QBFILEMODE = QBFileMode.qbFileOpenSingleUser;
 //       public QBFileMode QBFILEMODE = QBFileMode.qbFileOpenMultiUser;
        //public QBFileMode QBFILEMODE = QBFileMode.qbFileOpenDoNotCare;
        public string VENDERINITLINK = "/vendors";
        public string CUSTOMERINITLINK = "/customers";
        public string EMPLOYEEINITLINK = "/employees";
        public string BILLINITLINK = "/bills";
        public string ACCOUNTINITLINK = "/accounts";
        public string BILLPAYMENTINITLINK = "/billpayments";
        public string PAYROLLINITLINK = "/payrolls";
        public string TRANSACTIONINITLINK = "/transactions";

		//        public string COMPANYNAME = getConfigurationGroup("CompanyName");
		public string COMPANYNAME = "COMPANY";
        public string TRANSACTIONTITLE = "Transaction";


        public string VENDORQUERY = "VendorQueryRq";
        public string CUSTOMERQUERY = "CustomerQueryRq";
        public string EMPLOYEEQUERY = "EmployeeQueryRq";
        public string ACCOUNTQUERY = "AccountQueryRq";
        public string BILLQUERY = "BillQueryRq";
        public string BILLPAYCHECKQUERY = "BillPaymentCheckQueryRq";
        public string BILLPAYCREDITCARDQUERY = "BillPaymentCreditCardQueryRq";
        public string PAYROLLSUMMARYREPORTQUERY = "PayrollSummaryReportQueryRq";
        public string PAYROLLSUMMARYTAGNAME = "PayrollSummaryReportType";
        public string PAYROLLSUMMARYTAGVAL = "EmployeeEarningsSummary";
        public string TRANSACTIONQUERY = "TransactionQueryRq";
        public string OTHERNAMEQUERY = "OtherNameQueryRq";
        



        public string BILLPAYMENTCHECKTYPE = "Check";
        public string BILLPAYMENTCREDITTYPE = "Credit";

        public string[] TRANSACTIONTYPE = { "BillPaymentCreditCard", "Bill", "BillPayment", "Paycheck", "Deposit", "VendorCredit" };
        public string[] TRANSACTIONlINK = { "/expense", "/billTrans", "/billPayment", "/paycheck", "/deposit", "/vendorCredit" };

//        public string appID = getConfigurationGroup("appID");   //Intended to eventually allow QuickBooks to link to a listing on Solutions Marketplace. empty is possible.
		public string appID = "1233556";
                                                                     //        public string appName = "Test"; //name of appear in QuickBooks
 //       public string appName = getConfigurationGroup("appName"); //name of appear in QuickBooks
		public string appName = "Test";
        public int RandomMin = 100001;
        public int RandomMax = 999999;
        
    }
}
