
namespace LargestOFThree
{
    public class Action
    {
        public void operation()
        {
            System.Console.WriteLine("Enter number1: ");
            int number1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter number2: ");
            int number2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter number3: ");
            int number3 = int.Parse(Console.ReadLine());


            if(number1 > number2)
            {
                if(number1 > number3)
                {
                    System.Console.WriteLine($"Number {number1} is greater");
                }
               
            }else if(number2 > number3)
            {
                System.Console.WriteLine($"Number {number2} is greater");
            }
             else
                {
                    System.Console.WriteLine($"Number {number3} is greater");
                }
        }
    }
}