using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fundamentals;

namespace UnitTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void CanBeCancelledBy_IfUser_Behavior()
        {
            User userObject = new User();
            var obj = new Reservation() { MadeBy = userObject};

            bool result = obj.CanBeCancelledBy(userObject);

            Assert.AreEqual(result, true);

          
        }

        [TestMethod]
        public void CanbeCalledBy_NonUser_Behavior()
        {
            var obj = new Reservation();

            User userObject = new User();

            bool result = obj.CanBeCancelledBy(userObject);
            Assert.AreEqual(result, false);
        }
    }
}
