using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Transaction
{
    public class TransactionType: Links<LinksItem>
    {
        public string TransType { get; set; }
    }
}
