using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwaggerTest.Models.Bill;
using SwaggerTest.Models.BillPayment;

namespace SwaggerTest.Models.Vendor
{
    public class VendorInsideEmbed2
    {
        public List<BillInfo> Bills { get; set; }
        public List<BillPaymentInfo> BillPayments { get; set; }

    }
}
