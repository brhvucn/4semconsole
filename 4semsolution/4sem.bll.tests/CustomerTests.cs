using _4sem.bll.tests.FakeObjects;
using _4sem.BLL.Services;
using _4sem.BLL.Services.Contracts;
using _4sem.Domain;

namespace _4sem.bll.tests
{
    public class CustomerTests
    {
        [Fact]
        public void SaveInvalidCustomerExpectException()
        {
            //Arrange
            FakeCustomerRepository myFakeCustomerRepository = new FakeCustomerRepository();
            ICustomerService serviceUnderTest = new CustomerService(myFakeCustomerRepository);
            //Act
            Assert.Throws<ArgumentNullException>(()=> serviceUnderTest.ValidateAndSaveCustomer(null));
            //Assert
        }

        [Fact]
        public void GetNullCustomerExpectFail()
        {
            //Arrange
            FakeCustomerRepository myFakeCustomerRepository = new FakeCustomerRepository();
            ICustomerService serviceUnderTest = new CustomerService(myFakeCustomerRepository);
            //Act
            Customer customer = serviceUnderTest.ReadCustomer(1);
            //Assert
            Assert.NotNull(customer);
        }
    }
}