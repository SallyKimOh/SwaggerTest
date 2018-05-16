using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models
{
    public class LinksItem
    {
        public LinksItemSub Self { get; set; }
        [JsonIgnore]
        public LinksItemSub Collection { get; set; }
        [JsonIgnore]
        public LinksItemSub Template { get; set; }
    }
}
