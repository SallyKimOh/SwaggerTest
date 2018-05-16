using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models
{

    public class LinkItemSub : LinkItems
    {
        public string Title { set; get; }
        
        public string Rel { set; get; }

        public string Href { set; get; }

    }
}
