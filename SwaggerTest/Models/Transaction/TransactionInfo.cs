using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models.Transaction
{
    public class TransactionInfo : TransactionType
    {
        public string ID { get; set; }
        [JsonIgnore]
        public string EmployeeID { get; set; }
        [JsonIgnore]
        public string VendorID { get; set; }
    }
}
