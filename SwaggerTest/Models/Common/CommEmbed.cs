using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Common
{
    public class CommEmbed<T>
    {
        public T _embedded { get; set; }

    }
}
