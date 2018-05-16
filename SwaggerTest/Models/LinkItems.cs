using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models
{
    public class LinkItems
    {
//        public string Title { set; get; }

//        public string Rel { set; get; }

//        public string Href { set; get; }

        public string Self { get; set; }
        public string Collection { get; set; }
        public string Template { get; set; }

        //public bool IsHrefTemplated
        //{
        //    get { return this.Href.Contains("{") && this.Href.Contains("}"); }
        //}




    }
}
