using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    public class ProductRepo
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(2);

            Console.WriteLine("Object: " +product.ToString());

            if (productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted Sizes";
                product.CurrentPrice = 15.96M;
            }
            
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                //Call an Insert Stored Procedure

            }
            else
            {
                //Call an Update Stored Procedure
            }
            return success;
        }
    }
}
