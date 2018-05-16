using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Payroll
{
    public class PayRollEmbed<T>
    {
        public T Payrolls { get; set; }
    }
}
