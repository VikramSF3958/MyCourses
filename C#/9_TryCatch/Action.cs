
namespace _9_TryCatch
{
    public class Action
    {
        public void Operations()
        {
            System.Console.Write("Enter number1: ");
            int number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter number2: ");
            int number2 = int.Parse(Console.ReadLine());

            try
            {
                int result = number1 / number2;
            }
            catch(Exception e)
            {
                System.Console.WriteLine($"Exception Occured: {e.Message}");
            }
        }
    }
}