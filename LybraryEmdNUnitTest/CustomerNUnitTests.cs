using NUnit.Framework;

namespace LibraryEmd
{
    [TestFixture]

    public class CustomerNUnitTests
    {
        private Customer customer;

        [SetUp]

        public void Setup() //initialize classes abd objects
        {
            customer = new Customer();
        }

        [Test]

        public void  CreateFullName_InputFirstNameLastName_ReturnFullName( )
        {
            //arrange , is not necessary if I have Setup Method          

            //Act

           customer.CreateFullName("Emma", "Marti Diaz");

            //Assert

            Assert.That(customer.CustomerName, Is.EqualTo("Emma Marti Diaz"));
            Assert.AreEqual(customer.CustomerName, "Emma Marti Diaz");
            Assert.That(customer.CustomerName, Does.Contain("Marti"));
            Assert.That(customer.CustomerName, Does.Contain("marti").IgnoreCase);
            Assert.That(customer.CustomerName, Does.StartWith("Emma"));
            Assert.That(customer.CustomerName, Does.EndWith("Diaz"));
        }

        [Test]

        public void CustomerName_NoValues_ReturnNull()
        { 
            Assert.IsNull(customer.CustomerName);
        }
    }
}
