using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models.Vendor
{
//    public class VendorInfo : LinkedResource
    public class VendorInfo : Links<LinksItem>
    {
        public string ID { get; set; }
        public string VendorName { get; set; }
//        public Links<LinksItem> _ling { get; set; }
        [JsonIgnore]
        public string AccountNumber { get; set; }

    }
}
