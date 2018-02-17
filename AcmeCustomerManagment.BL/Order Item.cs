using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    class Order_Item
    {
        public Order_Item()
        {

        }
        public Order_Item(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductID { get; set; }
        public int OrderQuantity { get;  set; }
        public decimal? PurchasePrice { get; set; }
        
        public bool Validate()
        {
            var isValid = true;

            if (OrderItemId <= 0) isValid = false;
            if (ProductID <= 0) isValid = false;
            if (OrderQuantity <= 0) isValid = false;

            return isValid;
        }

        public Order_Item Retrieve(int orderItemId)
        {
            return new Order_Item();
        }

        public bool Save()
        {
            return true;
        }
    }
}
