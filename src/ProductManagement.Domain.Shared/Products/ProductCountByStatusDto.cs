using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Shared.Products
{
    public class ProductCountByStatusDto
    {
        public string Status { get; set; }
        public int Count { get; set; }
    }
}
