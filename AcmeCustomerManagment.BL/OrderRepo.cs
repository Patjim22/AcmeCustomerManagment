using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    public class OrderRepo
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            /*if (orderId ==10)
            {
                order.OrderDate = new DateTimeOffset(2014,);
            }
            */

            return new Order();
        }

        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges && order.IsValid)
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