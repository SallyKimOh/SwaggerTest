using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Home

{
    public class HomeLinksItem
    {
        public LinksItemSub Self { get; set; }
        public LinksItemSub Vendors { get; set; }
        public LinksItemSub Customers { get; set; }
        public LinksItemSub Employees { get; set; }
        public LinksItemSub Accounts { get; set; }
        public LinksItemSub Bills { get; set; }
        public LinksItemSub BillPayments { get; set; }
        public LinksItemSub PayRolls { get; set; }
        public LinksItemSub Transactions { get; set; }

    }
}
