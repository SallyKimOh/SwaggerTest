using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Transaction
{
    public class TransEmbed<T>
    {
        public T Trans { get; set; }
    }
}
