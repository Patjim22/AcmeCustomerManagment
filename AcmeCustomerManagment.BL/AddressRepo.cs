using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    public class AddressRepo
    {
        //Retrieve 1 address

        public Address Retrieve(int addressId)
        {
            //create instance of Address
            Address address = new Address(addressId);

            if (addressId ==1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.StateProv = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;

            /*public IEnumerable<Address> RetrieveByCustomerId(int customerId)
            {
                var addressList = new List<Address>();
                address = new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    StateProv = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144",
                };
                addressList.Add(address);

                address = new Address(2)
                {
                    AddressType = 2,
                    StreetLine1 = "green Dragon",
                    City = "ByWater",
                    StateProv = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "146",
                };
                addressList.Add(address);
                
                
            }*/
        }
    }
}
