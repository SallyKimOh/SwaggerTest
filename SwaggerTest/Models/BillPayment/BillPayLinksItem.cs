using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.BillPayment
{
    public class BillPayLinksItem : LinksItem
    {
        public LinksItemSub Vendor { get; set; }
        public LinksItemSub Account { get; set; }
        public LinksItemSub Bills { get; set; }

    }
}
