using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Bill
{
    public class BillLinksItem : LinksItem
    {
        public LinksItemSub Vendor { get; set; }
        public LinksItemSub BillPayment { get; set; }

    }
}
