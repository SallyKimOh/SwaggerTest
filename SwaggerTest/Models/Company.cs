using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models
{
    public class Company : LinkedResourceCollection<FindTypes>
    {
    
        public string CompanyNm { get; set; }
        public string Description { get; set; }

        public Company()
        : base()
        {
        }

        public Company(List<FindTypes> items)
        : base(items)
        {
        }


    }
}

