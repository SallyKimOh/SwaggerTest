using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Transaction
{
    public class TransactionDetail : TransactionInfo
    {
        public string EmployeeName { get; set; }
        public string AccountNumber { get; set; }
        public string FinancialNumber { get; set; }
        public string BranchNumber { get; set; }
        public string AccountID { get; set; }
        public string AccountMemo { get; set; }
        public double Amount { get; set; }
        public string TransDate { get; set; }


    }
}
