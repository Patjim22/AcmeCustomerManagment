﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    class Order
    {
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
