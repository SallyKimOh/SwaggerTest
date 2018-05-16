using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Models.BillPayment
{
    public class BillPayDetailInfo2<T> : CommInfo<T>
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}
