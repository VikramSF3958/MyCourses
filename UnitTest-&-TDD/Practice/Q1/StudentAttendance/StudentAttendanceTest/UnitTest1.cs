using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentAttendance;


namespace StudentAttendanceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            bool result = StudentAttendance.Attendance.AttendanceStatus(true);

            //Expected Result
            bool Expected = true;

            //Testing
            Assert.AreEqual(Expected, result);
        }
    }
}
