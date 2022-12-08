using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderCalculator;

namespace OrderCalculationUnitTest
{
    [TestClass]
    public class OrderCalcUnitTest1
    {
        [TestMethod]
        public void getPrices_inputPrice_IsInteger_false()
        {
            //Arrange
            var Price1 = "12.11";
            var Price2 = "11";

            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getPrices(Price1, Price2);

            //Assert
            Assert.AreEqual(0, result);
            
        }

        [TestMethod]
        public void getPrices_inputPrice_IsInteger_true()
        {
            //Arrange
            var Price1 = 12;
            var Price2 = 11;

            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getPrices(Price1, Price2);

            //Assert
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void getDiscount_inputDiscount_IsInteger()
        {
            //Arrange
            var Discount = 18;

            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getDiscount(Discount);

            //Assert
            Assert.AreEqual(Discount, result);
        }

        [TestMethod]
        public void getCountryName_inputCountry_IsCountry_True()
        {
            //Arrange
            var Country = "Russia";

            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getCountryName(Country);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void getCountryName_inputCountry_IsCountry_False()
        {
            //Arrange
            var Country = "Britain";

            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getCountryName(Country);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void getPrices_IsNegativeValues_True()
        {
            //Arrange
            var Price1 = 10;
            var Price2 = -11;


            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getPrices(Price1, Price2);

            //Assert
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void getPrices_IsNegativeValues_False()
        {
            //Arrange
            var Price1 = 10;
            var Price2 = 11;


            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getPrices(Price1, Price2);

            //Assert
            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void ApplyDiscount_ifUnitedStates_True()
        {
            //Arrange
            
            OrderTotal obj = new OrderTotal();
            obj.Country = "United States";

            //Act
            var result = obj.forDiscount();

            //Assert
            Assert.IsTrue(result, "Recieved input is not United States");
        }

        [TestMethod]
        public void ApplyDiscount_ifUnitedStates_False()
        {
            //Arrange

            OrderTotal obj = new OrderTotal();
            obj.Country = "India";

            //Act
            var result = obj.forDiscount();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsTaxApplicable_ifIndia_True()
        {
            //Arrange

            OrderTotal obj = new OrderTotal();
            string country = "India";

            //Act
            var result = obj.IsTaxApplicable(country);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsTaxApplicable_ifIndia_False()
        {
            //Arrange

            OrderTotal obj = new OrderTotal();
            string country = "Berlin";

            //Act
            var result = obj.IsTaxApplicable(country);

            //Assert
            Assert.IsFalse(result);

        }



        [TestMethod]
        public void OrderTotalPrice_totalPrice_IsTrue()
        {
            //Arrange
            OrderTotal obj = new OrderTotal();

            string countryName = "India";

            //Act
            var result = obj.OrderTotalPrice(countryName);

            //Assert
            Assert.IsTrue(result);
        }



        [TestMethod]
        public void OrderTotalPrice_totalPrice_IsFalse()
        {
            //Arrange
            OrderTotal obj = new OrderTotal();

            string countryName = "United States";

            //Act
            var result = obj.OrderTotalPrice(countryName);

            //Assert
            Assert.IsFalse(result);
        }


    }
}
