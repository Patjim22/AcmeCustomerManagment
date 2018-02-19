using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    public class Customer :EntityBase
    {
        public Customer()
            :this(0)//chains to the constructor with parapemeter to always have a list made
        {

        }
        public Customer(int customerId)
        {
            this.CustomerID = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string Email { get; set; }
        public int CustomerID { get; private set; }


        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return FullName ;
        }
    }
}
