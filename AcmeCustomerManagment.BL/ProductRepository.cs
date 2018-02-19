using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId ==2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted Sizes";
                product.CurrentPrice = 15.96M;
            }
            
            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
