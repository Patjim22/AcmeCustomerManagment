using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcmeCustomerManagment.BL;

namespace ACM.BL_Test
{
    [TestClass]
    public class CustomerRepoTest
    {
        [TestMethod]
        public void CustomerRepoRetrieveTest()
        {
            //Arrange
            var customerRepoistory = new CustomerRepo();
            var expected = new Customer(1)
            {
                Email = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };


            //Act
            var actual = customerRepoistory.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
