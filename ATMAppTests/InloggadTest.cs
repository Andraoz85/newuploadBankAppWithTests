using ATMApp;

namespace ATMAppTests
{
    public class InloggadTests
    {

        [Fact]
        public void UserCountTest()
        {
            //Arrange
            List<Customer> customers = new List<Customer>();
            //Act
            customers.Add(new Customer(555, 444));
            customers.Add(new Customer(222, 222));
            //Assert
            Assert.True(customers.Count == 2);
        }

        [Fact]
        public void UserLoginTest()
        {
            //Arrange
            Customer customer = new Customer();
            //Act
            List<Customer> customers = customer.CustomerList();
            //Assert
            Assert.True(customers.Count == 3);
            Assert.True(customers.Find(x => x.GetName() == "Poor Peggy")?.GetPinCode() == 999);
            Assert.True(customers.Find(x => x.GetName() == "Lucky Luke")?.GetPinCode() != 999);

        }
    }

}