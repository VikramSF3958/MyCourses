
namespace _8_SwitchStatement
{
    public class Action
    {
        public void Operations()
        {
            System.Console.Write("Enter number1: ");
            int number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter number2: ");
            int number2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("1.Addition\n2.subtract\n3.Multiply\n4.Divide");
            System.Console.Write("Enter the option: ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {   
                    System.Console.WriteLine("Addition");
                    System.Console.WriteLine($"Result: {number1 + number2}");
                    break;
                }

                case 2:
                {   
                    System.Console.WriteLine("Subtraction");
                    System.Console.WriteLine($"Result: {number1 - number2}");
                    break;
                }

                case 3:
                {   
                    System.Console.WriteLine("Multiply");
                    System.Console.WriteLine($"Result: {number1 * number2}");
                    break;
                }

                case 4:
                {   
                    System.Console.WriteLine("Divide");
                    System.Console.WriteLine($"Result: {(double)number1/number2}");
                    break;
                }

                default:
                {   
                    System.Console.WriteLine("Invalid Options");
                    break;
                }
            }
        }

    }
}