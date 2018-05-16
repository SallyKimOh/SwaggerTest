using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.BillPayment
{
    public class BillPaymentInfo : Links<LinksItem>
    {
        public string ID { get; set; }
        public string PaymentType { get; set; } //Credit:Check

    }
}
