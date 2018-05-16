using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models.Bill
{
    public class PayRollInfo : Links<LinksItem>
    {
        public string ID { get; set; }

        //       [JsonIgnore]
        public string EmployeeName{ get; set; }
    }
}
