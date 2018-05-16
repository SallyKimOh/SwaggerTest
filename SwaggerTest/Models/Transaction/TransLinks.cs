using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Transaction
{
    public class TransLinks<T> : Links<T>
    {
        public string JobType { get; set; }

    }
}
