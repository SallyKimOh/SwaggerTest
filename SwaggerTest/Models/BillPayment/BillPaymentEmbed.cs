using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.BillPayment
{
    public class BillPaymentEmbed<T>
    {
        public T BillPayments { get; set; }

    }
}
