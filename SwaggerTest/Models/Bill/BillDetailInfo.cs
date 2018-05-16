using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models.Bill
{
    public class BillDetailInfo : BillInfo
    {
        public string VenderName { get; set; }
        public string AccountName { get; set; }
        public double AmountDue { get; set; }
        public double OpenAmount { get; set; }
        public string VendorID { get; set; }
        [JsonIgnore]
        public string TimeCre { get; set; }
        [JsonIgnore]
        public string TimeMod { get; set; }
        [JsonIgnore]
        public string BillPaymentID { get; set; }
        [JsonIgnore]
        public string BillPaymenType { get; set; }



    }
}
