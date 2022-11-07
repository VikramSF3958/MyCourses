using System;

namespace StudentAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = Attendance.AttendanceStatus(true);

            Console.WriteLine(result);
        }
    }
}
