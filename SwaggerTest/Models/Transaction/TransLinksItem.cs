using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwaggerTest.Data;

namespace SwaggerTest.Models.Transaction

{
    public class TransLinksItem
    {
/*
        public TransLinksItem()
        {
             foreach (var types in new ConstantValue().TRANSACTIONTYPE)
            {
                TransactionType type = new TransactionType();
                type.TransType = types;
                TransTypes.Add(type);
            }

        }


        [JsonIgnore]
        public List<TransactionType> TransTypes { get; set; }
*/

        public LinksItemSub BillPaymentCreditCard { get; set; }
        public LinksItemSub Bill { get; set; }
        public LinksItemSub BillPaymentCheck { get; set; }
        public LinksItemSub Paycheck { get; set; }
        public LinksItemSub Deposit { get; set; }
        public LinksItemSub VendorCredit { get; set; }
  
    }
}
