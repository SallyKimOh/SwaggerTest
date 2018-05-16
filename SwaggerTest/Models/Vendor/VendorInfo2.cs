using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models.Vendor
{
    public class VendorInfo2<T,E> : Links<T>
    {
        public string ID { get; set; }
        public string VendorName { get; set; }
        public double Balance { get; set; }
        public E _account { get; set; }
        public VendorInsideEmbed2 _embedded { get; set; }
   

    }
}
