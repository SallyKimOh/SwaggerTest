using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Home
{
    public class HomeLinks<T>: Links<T>
    {
        public string Company { get; set; }
        public string QbFileName { get; set; }

    }
}
