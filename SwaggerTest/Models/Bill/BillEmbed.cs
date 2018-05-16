using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Bill
{
    public class BillEmbed<T>
    {
        public T Bills { get; set; }
    }
}
