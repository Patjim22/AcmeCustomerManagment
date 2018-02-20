using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcmeCustomerManagment.BL;

namespace ACM.BL_Test
{
    [TestClass]
    public class ProductRepoTest
    {
        [TestMethod]
        public void ProductRepoRetrieveExistingTest()
        {
            //Arrange
            var productRepoistory = new ProductRepo();
            var expected = new Product(2)
            {
                ProductName = "Sunflower",
                ProductDescription = "Assorted Sizes",
                CurrentPrice = 15.96M
            };


            //Act
            var actual = productRepoistory.Retrieve(2);
            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            
        }
    }
}
