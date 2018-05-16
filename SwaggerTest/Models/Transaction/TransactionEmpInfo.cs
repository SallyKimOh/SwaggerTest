using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Transaction
{
    public class TransactionEmpInfo : TransactionComm
    {
        public string ID { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
    }
}
