using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Vendor
{
    public class VendorInsideEmbed<T,E>
    {
        public T Bills { get; set; }
        public E BillPayments { get; set; }


    }
}
