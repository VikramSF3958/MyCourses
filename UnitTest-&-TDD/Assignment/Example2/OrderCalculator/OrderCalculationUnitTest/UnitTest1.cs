using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderCalculator;

namespace OrderCalculationUnitTest
{
    [TestClass]
    public class OrderCalcUnitTest1
    {
        [TestMethod]
        public void getPrices_inputPrice_IsInteger()
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
        public void getCountryName_inputCountry_IsCountry()
        {
            //Arrange
            var Country = "Germany";

            //Act
            OrderTotal obj = new OrderTotal();
            var result = obj.getCountryName(Country);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void getPrices_IfNegative_IsInvalid()
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
        public void IsTaxApplicable_ifIndia_IsTrue()
        {
            //Arrange
            
            OrderTotal obj = new OrderTotal();
            obj.Country = "India";

            //Act
            var result = obj.IsTaxApplicable();

            //Assert
            Assert.IsTrue(result, "Not India");
        }

        [TestMethod]

        public void OrderTotalPrice_totalPrice_IsTrue()
        {
            //Arrange
            OrderTotal obj = new OrderTotal();
            obj.Price1 = 10;
            obj.Price2 = 11;
            obj.Discount = 18;
            obj.Country = "Germany";

           // var re = obj.IsTaxApplicable();

            //Act
            var result = obj.OrderTotalPrice();

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}
