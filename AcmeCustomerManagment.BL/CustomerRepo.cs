using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    public class CustomerRepo
    {
        private AddressRepo addressRepository { get; set; }

        public CustomerRepo()
        {
            addressRepository = new AddressRepo();
        }


        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            //Create instance of Customer class
            Customer customer = new Customer(customerId);
            //customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            //Retrieves defined customer

            //temp hard coded values to return 
            //a customer
            if (customerId==1)
            {
                customer.Email = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";

            }

            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            //Code that saves defined Customer
            var success = true;

            if (customer.HasChanges && customer.IsValid)
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
