using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwaggerTest.Models.Common;

namespace SwaggerTest.Models.Employee
{
    public class EmployeeInfo<T> : Links<T>
    {
        public string ID { get; set; }

        public string Name { get; set; }
        [JsonIgnore]
        public string AccountNumber { get; set; }

    }
}
