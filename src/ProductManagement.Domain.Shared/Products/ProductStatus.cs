using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Products
{
    public enum ProductStatus: byte
    {
        [Description("Sold")]
        Sold,
        [Description("InStock")]
        InStock,
        [Description("Damaged")]
        Damaged
    }
}
