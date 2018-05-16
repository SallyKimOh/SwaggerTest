using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Transaction
{
    public class TransactionVendorInfo : TransactionComm
    {
        public string ID { get; set; }
        public string VendorID { get; set; }
        public string VendorName { get; set; }
    }
}
