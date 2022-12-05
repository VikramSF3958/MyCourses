
namespace ArithmeticOperations
{
    public class Operations
    {
        public void Addition()
        {   
            System.Console.WriteLine("Addition");
            int number1 = 0, number2 = 0;
            System.Console.Write("Enter Number 1: ");
            number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Number2: ");
            number2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Sum: {number1+number2}");

        }

        public void Mulitplication()
        {
            System.Console.WriteLine("Multiplication");
            int number1 = 0, number2 = 0;
            System.Console.Write("Enter Number 1: ");
            number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Number2: ");
            number2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Product: {number1 * number2}");

        }

        public void Subtraction()
        {   
            System.Console.WriteLine("Subtraction");
            int number1 = 0, number2 = 0;
            System.Console.Write("Enter Number 1: ");
            number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Number2: ");
            number2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Subtract: {number1 - number2}");
        }

        public void Division()
        {   
            System.Console.WriteLine("Division");
            int number1 = 0, number2 = 0;
            System.Console.Write("Enter Number 1: ");
            number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Number2: ");
            number2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Divide: {(double)number1/number2}");
        }

        public void Modulous()
        {   
            System.Console.WriteLine("Modulus");
            int number1 = 0, number2 = 0;
            System.Console.Write("Enter Number 1: ");
            number1 = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Number2: ");
            number2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Modulus: {number1 % number2}");
        }
    }
}