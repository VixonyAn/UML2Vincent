using PizzaLibrary.Services;
using PizzaLibrary.Models;
using PizzaLibrary.Data;

namespace PizzaTest
{
    [TestClass]
    public class UnitTest1
    {
        CustomerRepository cRepo = new CustomerRepository();
        MenuItemRepository menuRepo = new MenuItemRepository();

        public void TestSetup()
        {
            Customer._counter = 0;
            MockData.Reset();
            cRepo = new CustomerRepository();
            menuRepo = new MenuItemRepository();
        }

        [TestMethod]
        public void CRepoCount()
        {
            //Arrange
            TestSetup();

            //Act

            //Assert
            Assert.AreEqual(4, cRepo.Count);
        }

        [TestMethod]
        public void AddCust()
        {
            //Arrange
            TestSetup();

            //Act
            int beforeCount = cRepo.Count;
            cRepo.AddCustomer(new Customer("Bob", "69696969", "street 69"));
            int afterCount = cRepo.Count;

            //Assert
            Assert.AreEqual(4, beforeCount);
            Assert.AreEqual(beforeCount + 1, afterCount);
        }

        [TestMethod]
        public void GetAllCust()
        {
            //Arrange
            TestSetup();

            //Act
            bool areSame = true;
            foreach (Customer customer in cRepo.GetAll())
            {
                if (customer != MockData.CustomerData[customer.Mobile]) { areSame = false; break; }
            }

            //Assert
            Assert.IsTrue(areSame);
        }

        [TestMethod]
        public void GetAllMembers()
        {
            TestSetup();

            cRepo.GetCustomerByMobile("12121212").ClubMember = true;
            List<Customer> members = cRepo.GetAllMembers();

            Assert.AreEqual(1, members.Count);
        }

        [TestMethod]
        public void GetCustByNum()
        {
            //Arrange
            TestSetup();

            //Act
            string mobile = "12121212";
            Customer c1 = cRepo.GetCustomerByMobile(mobile);
            Customer c2 = MockData.CustomerData[mobile];

            //Assert
            Assert.AreEqual(c1, c2);
        }

        [TestMethod]
        public void RemoveCust()
        {
            //Arrange
            TestSetup();

            //Act
            int beforeCount = cRepo.Count;
            cRepo.RemoveCustomer("12121212");
            int afterCount = cRepo.Count;

            //Assert
            Assert.AreEqual(beforeCount, afterCount + 1);
        }
    }
}