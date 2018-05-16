using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Transaction
{
    public class TransBillPaymentEmbed<T>
    {
        public T BillPayments { get; set; }
    }
}
