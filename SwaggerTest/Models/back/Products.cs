using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.Models
{
    /// <summary>
    /// This represents the entity for product set.
    /// </summary>
    public class Products : LinkedResourceCollection<Product>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Products" /> class.
        /// </summary>
        public Products()
            : base()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Products" /> class.
        /// </summary>
        /// <param name="items">List of <see cref="Product" /> objects.</param>
        public Products(List<Product> items)
            : base(items)
        {
        }
    }
}