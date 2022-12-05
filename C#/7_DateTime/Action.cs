
namespace _7_DateTime
{
    public class Action
    {
        public void Operations()
        {
            System.Console.WriteLine($"Current Month: {DateTime.Now.Month }");
            System.Console.WriteLine($"Previous 3 Day: {DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Time: {DateTime.Now.ToString("hh:mm tt")}");

        }
    }
}