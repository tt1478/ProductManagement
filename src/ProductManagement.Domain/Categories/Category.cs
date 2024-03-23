using ProductManagement.Domain;
using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Categories
{
    public class Category: BaseEntity<Guid>
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}
