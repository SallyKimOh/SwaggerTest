﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models.Common

{
    public class CommLinksItem
    {
        public LinksItemSub Self { get; set; }
        public LinksItemSub Next { get; set; }
//        public LinksItemSub Prev { get; set; }
    }
}
