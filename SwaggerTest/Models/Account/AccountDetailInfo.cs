using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Models.Account
{
    public class AccountDetailInfo<T> : AccountInfo<LinksItem>
    {
        public T _embedded { get; set; }
        public double Balance { get; set; }
        public string BankNumber { get; set; }
        public string AccountType { get; set; }

    }
}
