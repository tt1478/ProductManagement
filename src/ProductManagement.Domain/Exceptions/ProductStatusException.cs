using ProductManagement.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain.Exceptions
{
    [Serializable]
    public class ProductStatusException<TKey>: Exception
    {
        public ProductStatusException()
        {
        }
        public ProductStatusException(TKey id, ProductStatus status): base(string.Format("Product with id {0} is {1}", id, status))
        {
            
        }
    }
}
