using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Models.BillPayment
{
    public class BillPayDetailInfo : BillPaymentInfo
    {
        public string Date { get; set; }
        public double Amount { get; set; }
        public string VendorID { get; set; }
        public string VendorName { get; set; }

        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public string BankID { get; set; }
        public string BankName { get; set; }
        [JsonIgnore]
        public string TimeCre { get; set; }
        [JsonIgnore]
        public string TimeMod { get; set; }

    }
}
