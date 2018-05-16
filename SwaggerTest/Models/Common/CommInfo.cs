using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models.Common
{
    public class CommInfo<T> : Links<T>
    {
        public string ID { get; set; }
    }
}
