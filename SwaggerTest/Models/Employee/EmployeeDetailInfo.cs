using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Models.Employee
{
    public class EmployeeDetailInfo<T> : EmployeeInfo<LinksItem>
    {
 //       public T _embedded { get; set; }
        public string EmployeeType { get; set; }
//        public string AccountNumber { get; set; }
        public string Payperiod { get; set; }
        public T _account { get; set; }

    }
}
