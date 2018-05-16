using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Vendor
{
    public class VendorBaseLinks<E> : VendorDetailInfo 
    {
        public E _embedded { get; set; }

    }
}
