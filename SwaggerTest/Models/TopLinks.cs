using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerTest.Models.Vendor;

namespace SwaggerTest.Models
{
    public class TopLinks<T,E> : Links<T>
    {
        public E _embedded { get; set; }

    }
}
