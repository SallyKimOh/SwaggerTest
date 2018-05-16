using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Models.Employee
{
    public class EmployeeInfo2<T,E> : Links<T>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }
        public string Payperiod { get; set; }
        public E _account { get; set; }

    }
}
