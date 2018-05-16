using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SwaggerTest.Models
{
    public abstract class LinkedResource
    {

        protected LinkedResource()
        {
            this.Links = new List<Link>();
        }
        /// <summary>
        /// Gets or sets the href of the link.
        /// </summary>
        /// <remarks>This value is injected during the serialisation as "self", unless <c>Links</c> contains it.</remarks>
        [JsonIgnore]
        public string Href { get; set; }

        /// <summary>
        /// Gets the list of <see cref="Link" /> objects.
        /// </summary>
//        [JsonIgnore]
        public List<Link> Links { get; private set; }
    }
}